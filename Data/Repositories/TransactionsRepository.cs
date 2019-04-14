using System;
using System.Data;
using System.Data.SqlClient;

namespace Data.Repositories
{
    public class TransactionsRepository : ITransactionsRepository

    {
        private string _getTransactionsByClientId = @"SELECT t.Id AS [ID of transaction], bka.IBAN AS [Money sent from],ba.IBAN AS [Money send to],t.VS,t.SS,t.CS,t.MessageForReceiver,T.MoneyTransaction,T.Category,t.DateOfTransaction FROm Transactions AS t
INNER JOIN(  BankAccount AS ba INNER JOIN Client AS c ON ba.ClientId=c.Id)ON t.BankAccountIdTo=ba.Id
INNER JOIN( BankAccount AS bka INNER JOIN Client AS cl ON bka.ClientId=cl.Id)ON t.BankAccountIdFrom=bka.Id
WHERE c.IdentityCard=@clientId OR cl.IdentityCard=@clientId";

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


        public DataSet GetTransactionsByClientId(string identityCard)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING);

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = _getTransactionsByClientId;
                command.Parameters.Add("@clientId", SqlDbType.VarChar).Value = identityCard;

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
