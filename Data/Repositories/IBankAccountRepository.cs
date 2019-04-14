using Data.Models;

namespace Data.Repositories
{
    public interface IBankAccountRepository
    {
        int CreateBankAccount(int clientId, string IBAN, decimal limit);
        BankAccount GetBankAccountByClientId(int clientId);
        int UpdatebankAccount(int clientId, decimal limit);
        int CloseBankAccount(int clientId);
    }
}
