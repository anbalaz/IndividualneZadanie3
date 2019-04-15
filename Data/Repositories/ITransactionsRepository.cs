using Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface ITransactionsRepository
    {
        DataSet SelectAllTransactions();

        DataSet SelectTransactionsByClientId(int clientId);

        int InsertTransaction(int from, int to, decimal sum, string category);

        int UpdateMessage(string fieldName, int transactionId, string message);

        int DeleteTransaction(int transactionId);
    }
}