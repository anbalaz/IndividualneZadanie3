using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Data.Repositories
{
    public class TownRepository:ITownRepository
    {

        public List<Town> GeListData()
        {
            List<Town> towns = new List<Town>();
            using (SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"SELECT c.*,t.Id,t.Name FROM TOWN as t
                                            INNER JOIN country AS c ON t.CountryId = c.Id
                                            WHERE CountryId = c.Id; ";
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            {
                                while (reader.Read())
                                {
                                    Country country = new Country();
                                    country.Id= reader.GetInt32(0);
                                    country.Name= reader.GetString(1);


                                    Town town = new Town();
                                    town.Country = country;
                                    town.Id = reader.GetInt32(2);
                                    town.Name = reader.GetString(3);

                                    towns.Add(town);
                                }
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Exception occured: \n{ ex}");
                    }
                }
                return towns;
            }
        }
    }
}