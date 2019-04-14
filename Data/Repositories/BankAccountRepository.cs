using Data.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Data.Repositories
{
    public class BankAccountRepository : IBankAccountRepository
    {

        private string _createClient = @"INSERT INTO BankAccount(ClientId,IBAN,CreationAccountDate,Limit)
                                        VALUES (@clientId,@IBAN,@time,@limit);";

        private string _getBankAccountByClientId = @"SELECT 
                                                     ba.Id
                                                    ,IBAN 
                                                    ,CreationAccountDate
                                                    ,TerminationDate
                                                    ,CurrentSum
                                                    ,Limit FROM BankAccount as ba
                                                    INNER JOIN Client as c ON ba.ClientId= c.Id
                                                    WHERE IdentityCard =@clientId;";


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
                        command.CommandText = _createClient;
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

        public BankAccount GetBankAccountByClientId(string clientId)
        {
            BankAccount bankAccount = new BankAccount();
            using (SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = _getBankAccountByClientId;
                    command.Parameters.Add("@clientId", SqlDbType.VarChar).Value = clientId;
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
    }
}
