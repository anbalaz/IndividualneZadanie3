using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Data.Repositories
{
    public class CreditCardRepository : ICreditCardRepository
    {
        public List<CreditCard> GeListData()
        {
            List<CreditCard> creditCards = new List<CreditCard>();
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
                                    BankAccount bankAccount = new BankAccount();

                                    CreditCard creditCard = new CreditCard();
                                    creditCard.Id = reader.GetInt32(0);
                                    //creditCard.Name = reader.GetString(1);

                                    creditCards.Add(creditCard);
                                }
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Exception occured: \n{ ex}");
                    }
                }
                return creditCards;


            }
        }
    }
}