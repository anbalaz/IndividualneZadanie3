using System;
using System.Data;
using System.Data.SqlClient;

namespace Data.Repositories
{
    public class TransactionsRepository : ITransactionsRepository

    {
        private string _getTransactionsByClientId = @"SELECT t.Id AS [ID of transaction], 
                                                    bka.IBAN AS [Money sent from],
                                                    ba.IBAN AS [Money send to],
                                                    t.VS,t.SS,t.CS,t.MessageForReceiver,
                                                    T.MoneyTransaction,T.Category,t.DateOfTransaction 
                                                    FROm Transactions AS t
                                                    INNER JOIN(  BankAccount AS ba INNER JOIN Client AS c ON ba.ClientId=c.Id)ON t.BankAccountIdTo=ba.Id
                                                    INNER JOIN( BankAccount AS bka INNER JOIN Client AS cl ON bka.ClientId=cl.Id)ON t.BankAccountIdFrom=bka.Id
                                                    WHERE c.Id=@id OR cl.Id=@id";

        private string _insertTransaction = @"INSERT INTO Transactions(BankAccountIdFrom,BankAccountIdTo,MoneyTransaction,Category,DateOfTransaction)
                                              output inserted.Id
                                              VALUES ((SELECT Id FROM BankAccount WHERE ID=@from),(SELECT Id FROM BankAccount WHERE ID=@to),@sum,@category,GETDATE());";

        public DataSet GetAllTransactions()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING);
                string query = @"SELECT t.Id AS[ID of transaction], 
                            bka.IBAN AS[Money sent from], 
                            ba.IBAN AS[Money send to], 
                            t.VS,t.SS,t.CS,t.MessageForReceiver,T.MoneyTransaction,T.Category,t.DateOfTransaction 
                            FROm Transactions AS t
                            INNER JOIN BankAccount AS ba ON t.BankAccountIdTo = ba.Id
                            INNER JOIN BankAccount AS bka ON t.BankAccountIdFrom = bka.Id;";

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds, "Transactions");
                DataTable dt = ds.Tables["Transactions"];

                return ds;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Exception occured: \n{ ex}");
                return ds;
            }
        }

        public DataSet GetTransactionsByClientId(int clientId)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING);

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = _getTransactionsByClientId;
                command.Parameters.Add("@id", SqlDbType.Int).Value = clientId;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds, "Transactions");
                DataTable dt = ds.Tables["Transactions"];

                return ds;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Exception occured: \n{ ex}");
                return ds;
            }
        }

        public int InsertTransaction(int from, int to, decimal sum, string category)
        {
            using (SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = _insertTransaction;
                    command.Parameters.Add("@from", SqlDbType.Int).Value = from;
                    command.Parameters.Add("@to", SqlDbType.Int).Value = to;
                    command.Parameters.Add("@sum", SqlDbType.Decimal).Value = sum;
                    command.Parameters.Add("@category", SqlDbType.NVarChar).Value = category;
                    try
                    {
                            return Convert.ToInt32(command.ExecuteScalar());
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Exception occured: \n{ ex}");
                    }
                }
                return 0;
            }

        }

        public int UpdateMessage(string fieldName, int transactionId, string message)
        {
            using (SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING))
            {
                string updateMessage = $"Update Transactions SET {fieldName}= @Message WHERE ID = @transactionId";

                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = updateMessage;
                    command.Parameters.Add("@transactionId", SqlDbType.Int).Value = transactionId;
                    command.Parameters.Add("@Message", SqlDbType.NVarChar).Value = message;
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
