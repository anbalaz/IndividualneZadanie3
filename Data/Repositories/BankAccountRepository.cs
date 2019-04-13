using System;
using System.Data;
using System.Data.SqlClient;

namespace Data.Repositories
{
    public class BankAccountRepository: IBankAccountRepository
    {

        private string _createClient = @"INSERT INTO BankAccount(ClientId,IBAN,CreationAccountDate,Limit)
                                        VALUES (@clientId,@IBAN,@time,@limit);";


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
    }
}
