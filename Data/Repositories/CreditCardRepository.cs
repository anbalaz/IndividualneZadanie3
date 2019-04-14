using Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data.Repositories
{
    public class CreditCardRepository : ICreditCardRepository
    {

        private string _getCreditCardListByClientId = @"SELECT cc.Id,
                                                        cc.CreationCardDate,
                                                        cc.ExpirationDate, 
                                                        cc.IsCardBlocked, 
                                                        cc.PasswordCard FROM CreditCard as cc
                                                    INNER JOIN (BankAccount AS ba INNER JOIN Client as c ON ba.ClientId= c.Id)ON cc.BankAccountId= ba.Id
                                                     WHERE c.Id = @id;";
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

        public List<CreditCard> GetCreditCardListByClientId(int clientId)
        {
            List<CreditCard> creditCards = new List<CreditCard>();
            using (SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = _getCreditCardListByClientId;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = clientId;
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            {
                                while (reader.Read())
                                {
                                    CreditCard creditCard = new CreditCard();
                                    creditCard.Id = reader.GetInt32(0);
                                    creditCard.CreationCardDate = reader.GetDateTime(1);
                                    creditCard.ExpirationDate = reader.GetDateTime(2);
                                    creditCard.IsCardBlocked = reader.GetBoolean(3);
                                    creditCard.PasswordCard = reader.GetString(4);
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