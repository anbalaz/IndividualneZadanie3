using Data.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Data.Repositories
{
    public class BankAccountRepository : IBankAccountRepository
    {

        private string _createBankAccount = @"INSERT INTO BankAccount(ClientId,IBAN,CreationAccountDate,Limit)
                                            VALUES (@clientId,@IBAN,@time,@limit);";

        private string _closeBankAccount = @"Update BankAccount 
                                             SET TerminationDate=GETDATE()
                                             WHERE ClientId=@id;";

        private string _getBankAccountByClientId = @"SELECT 
                                                     ba.Id
                                                    ,IBAN 
                                                    ,CreationAccountDate
                                                    ,TerminationDate
                                                    ,CurrentSum
                                                    ,Limit FROM BankAccount as ba
                                                    INNER JOIN Client as c ON ba.ClientId= c.Id
                                                    WHERE c.Id =@id;";

        private string _updateBankAccount = @"	Update BankAccount 
                                                SET Limit=@limit
                                                WHERE ClientId=@id";

        private string _updatebankAccountFrom = @"Update BankAccount
                                                  SET CurrentSum=CurrentSum-@sum
                                                  WHERE ID=(SELECT BankAccountIdFrom
                                                  			FROM Transactions
                                                  			WHERE Id=@transactionId);";

        private string _updatebankAccountTo = @"Update BankAccount
                                                  SET CurrentSum=CurrentSum+@sum
                                                  WHERE ID=(SELECT BankAccountIdTo
                                                  			FROM Transactions
                                                  			WHERE Id=@transactionId);";

        private string _selectBankAccountByCardNumber= @"SELECT 
                                                         ba.Id
                                                        ,IBAN 
                                                        ,CreationAccountDate
                                                        ,TerminationDate
                                                        ,CurrentSum
                                                        ,Limit FROM BankAccount as ba
                                                        INNER JOIN CreditCard as cc ON ba.Id= cc.BankAccountId
                                                        WHERE cc.CardNumber =@cardNumber;";

        public int CreateBankAccount(int clientId, string IBAN, decimal limit)
        {
            DateTime time = DateTime.Now;

            using (SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = _createBankAccount;
                        command.Parameters.Add("@clientId", SqlDbType.Int).Value = clientId;
                        command.Parameters.Add("@IBAN", SqlDbType.VarChar).Value = IBAN;
                        command.Parameters.Add("@time", SqlDbType.Date).Value = time;
                        command.Parameters.Add("@limit", SqlDbType.Decimal).Value = limit;

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

        public BankAccount GetBankAccountByClientId(int clientId)
        {
            BankAccount bankAccount = new BankAccount();
            using (SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = _getBankAccountByClientId;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = clientId;
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            {
                                while (reader.Read())
                                {
                                    bankAccount.Id = reader.GetInt32(0);
                                    bankAccount.IBAN = reader.GetString(1);
                                    bankAccount.CreationAccountDate = reader.GetDateTime(2);
                                    if (!reader.IsDBNull(3))
                                    {
                                        bankAccount.TerminationDate = reader.GetDateTime(3);
                                    }
                                    else
                                    {
                                        bankAccount.TerminationDate = DateTime.MinValue;
                                    }
                                    bankAccount.CurrentSum = reader.GetDecimal(4);
                                    bankAccount.Limit = reader.GetDecimal(5);
                                }
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Exception occured: \n{ ex}");
                    }
                }
                return bankAccount;
            }
        }

        public BankAccount SelectBankAccountByCardNumber(int cardNumber)
        {
            BankAccount bankAccount = new BankAccount();
            using (SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = _selectBankAccountByCardNumber;
                    command.Parameters.Add("@cardNumber", SqlDbType.Int).Value = cardNumber;
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            {
                                while (reader.Read())
                                {
                                    bankAccount.Id = reader.GetInt32(0);
                                    bankAccount.IBAN = reader.GetString(1);
                                    bankAccount.CreationAccountDate = reader.GetDateTime(2);
                                    if (!reader.IsDBNull(3))
                                    {
                                        bankAccount.TerminationDate = reader.GetDateTime(3);
                                    }
                                    else
                                    {
                                        bankAccount.TerminationDate = DateTime.MinValue;
                                    }
                                    bankAccount.CurrentSum = reader.GetDecimal(4);
                                    bankAccount.Limit = reader.GetDecimal(5);
                                }
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Exception occured: \n{ ex}");
                    }
                }
                return bankAccount;
            }
        }

        public int UpdatebankAccount(int clientId, decimal limit)
        {
            using (SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = _updateBankAccount;
                        command.Parameters.Add("@id", SqlDbType.Int).Value = clientId;
                        command.Parameters.Add("@limit", SqlDbType.Decimal).Value = limit;

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

        public int CloseBankAccount(int clientId)
        {
            using (SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = _closeBankAccount;
                        command.Parameters.Add("@id", SqlDbType.Int).Value = clientId;

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

        public int UpdatebankAccountFrom(int transactionId, decimal sum)
        {
            using (SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = _updatebankAccountFrom;
                    command.Parameters.Add("@transactionid", SqlDbType.Int).Value = transactionId;
                    command.Parameters.Add("@sum", SqlDbType.Decimal).Value = sum;
                    try
                    {
                        if (command.ExecuteScalar() != null)
                        {
                            return Convert.ToInt32(command.ExecuteScalar());
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Exception occured: \n{ ex}");
                    }
                }
                return 0;
            }
        }

        public int UpdatebankAccountTo(int transactionId, decimal sum)
        {
            using (SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = _updatebankAccountTo;
                    command.Parameters.Add("@transactionid", SqlDbType.Int).Value = transactionId;
                    command.Parameters.Add("@sum", SqlDbType.Decimal).Value = sum;
                    try
                    {
                        if (command.ExecuteScalar() != null)
                        {
                            return Convert.ToInt32(command.ExecuteScalar());
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Exception occured: \n{ ex}");
                    }
                }
                return 0;
            }
        }
    }
}