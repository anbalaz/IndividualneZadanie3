using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Data.Repositories
{
    public class CountryRepository: ICountryRepository
    {
        public List<Country> SelectTowms()
        {
            List<Country> countries = new List<Country>();
            using (SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Town";
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

                                    countries.Add(country);
                                }
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Exception occured: \n{ ex}");
                    }
                }
                return countries;
            }
        }
    }
}
