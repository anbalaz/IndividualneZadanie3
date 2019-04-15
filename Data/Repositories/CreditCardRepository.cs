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

        private string _updateCardToBlock = @"	UPDATE CreditCard
                                                SET IsCardBlocked=@blockUnblock
                                                WHERE CardNumber=@cardNumber";

        private string _insertCreditCardByBankAccountId = @"INSERT INTO CreditCard (BankAccountId,CardNumber,CreationCardDate,ExpirationDate,IsCardBlocked,PasswordCard)
                            VALUES ((SELECT Id FROM BankAccount WHERE ID=@bankAccountId),@cardNumber,GETDATE(),DATEADD(YEAR,5,GETDATE()),0,@cardPassword);";

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

        public DataSet SelectCreditCardByCardByClientId(int clientId)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING);

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = _getCreditCardListByClientId;
                command.Parameters.Add("@id", SqlDbType.Int).Value = clientId;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds, "Cards");
                DataTable dt = ds.Tables["Cards"];

                return ds;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Exception occured: \n{ ex}");
                return ds;
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

        public int UpdateCardBlockUnblock(int cardNumber, int blockUnblock)
        {
            using (SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = _updateCardToBlock;
                    command.Parameters.Add("@cardNumber", SqlDbType.Int).Value = cardNumber;
                    command.Parameters.Add("@blockUnblock", SqlDbType.Bit).Value = blockUnblock;
                    try
                    {
                        return command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Exception occured: \n{ ex}");
                    }
                }
                return 0;
            }
        }

        public int InsertCreditCardByBankAccountId(int bankAccountId, int cardNumber, int cardPassword)
        {
            using (SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = _insertCreditCardByBankAccountId;
                        command.Parameters.Add("@bankAccountId", SqlDbType.Int).Value = bankAccountId;
                        command.Parameters.Add("@cardNumber", SqlDbType.Int).Value = cardNumber;
                        command.Parameters.Add("@cardPassword", SqlDbType.VarChar).Value = cardPassword;

                        return command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Exception occured: \n {ex}");
                        return 0;
                    }
                }
            }
        }
    }
}