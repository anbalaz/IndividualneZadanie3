using System;
using System.Data;
using System.Data.SqlClient;

namespace Data.Repositories
{
    public class TransactionsRepository : ITransactionsRepository
    {
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


    }
}
