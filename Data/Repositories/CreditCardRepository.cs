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
                                                        cc.CardNumber,
                                                        cc.CreationCardDate,
                                                        cc.ExpirationDate, 
                                                        cc.IsCardBlocked, 
                                                        cc.PasswordCard FROM CreditCard as cc
                                                    INNER JOIN (BankAccount AS ba INNER JOIN Client as c ON ba.ClientId= c.Id)ON cc.BankAccountId= ba.Id
                                                     WHERE c.Id = @id;";

        private string _SelectCreditCardByCardNumber = @"	SELECT Id, CardNumber, PasswordCard , IsCardBlocked, ExpirationDate, CreationCardDate
	                                                        FROM CreditCard
	                                                        WHERE CardNumber=@cardNumber";
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
                                    creditCard.CardNumber = reader.GetInt32(1);
                                    creditCard.CreationCardDate = reader.GetDateTime(2);
                                    creditCard.ExpirationDate = reader.GetDateTime(3);
                                    creditCard.IsCardBlocked = reader.GetBoolean(4);
                                    creditCard.PasswordCard = reader.GetString(5).Trim();
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

        public CreditCard SelectCreditCardByCardNumber(int cardNumber)
        {
            CreditCard creditCard = new CreditCard();
            using (SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = _SelectCreditCardByCardNumber;
                    command.Parameters.Add("@cardNumber", SqlDbType.Int).Value = cardNumber;
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            {
                                while (reader.Read())
                                {
                                    creditCard.Id = reader.GetInt32(0);
                                    creditCard.CardNumber = reader.GetInt32(1);
                                    creditCard.PasswordCard = reader.GetString(2).Trim();
                                    creditCard.IsCardBlocked = reader.GetBoolean(3);
                                    creditCard.ExpirationDate = reader.GetDateTime(4);
                                    creditCard.CreationCardDate = reader.GetDateTime(5);
                                }
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Exception occured: \n{ ex}");
                    }
                }
                return creditCard;
            }
        }
    }
}