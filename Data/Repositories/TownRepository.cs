using Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data.Repositories
{
    public class TownRepository : ITownRepository
    {

        private string _topTowns = @" SELECT TOP 5 t.Name AS Town, count(c.Id) as [Number of clients] FROM Client as c
                                      INNER JOIN Town as t ON c.TownId=t.Id
                                      INNER JOIN BankAccount as ba ON c.Id=ba.ClientId
                                      WHERE ba.id <>1 AND ba.TerminationDate IS Null
                                      Group BY t.Name
                                      ORDER BY [Number of clients] DESC";

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
                                    country.Id = reader.GetInt32(0);
                                    country.Name = reader.GetString(1);


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

        public DataSet SelectTopTowns()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING);

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = _topTowns;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds, "Towns");
                DataTable dt = ds.Tables["Towns"];

                return ds;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Exception occured: \n{ ex}");
                return ds;
            }
        }
    }
}