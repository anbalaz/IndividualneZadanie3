﻿using Data.Models;
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
                    command.CommandText = "SELECT * FROM Town";
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            {
                                while (reader.Read())
                                {
                                    Town town = new Town();
                                    town.Id = reader.GetInt32(0);
                                    town.Name = reader.GetString(1);

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