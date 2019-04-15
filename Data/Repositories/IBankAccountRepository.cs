using Data.Models;
using System.Data;

namespace Data.Repositories
{
    public interface IBankAccountRepository
    {
        int CreateBankAccount(int clientId, string IBAN, decimal limit);
        BankAccount SelectBankAccountByClientId(int clientId);
        int UpdatebankAccount(int clientId, decimal limit);
        int CloseBankAccount(int clientId);
        int UpdatebankAccountFrom(int transactionId, decimal sum);
        int UpdatebankAccountTo(int transactionId, decimal sum);
        BankAccount SelectBankAccountByCardNumber(int cardNumber);
        BankAccount SelectBankAccountByIBAN(string IBAN);
        decimal SelectSumOfMoneyOnAccounts();
        int SelectCountOfClients();
        DataSet SelectTopAccounts();
    }
}