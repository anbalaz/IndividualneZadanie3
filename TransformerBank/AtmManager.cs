using Data.Models;
using Data.Repositories;

namespace TransformerBank
{
    public class AtmManager
    {
        private ICreditCardRepository _creditCardRepository = new CreditCardRepository();
        private IBankAccountRepository _bankAccountRepository = new BankAccountRepository();
        private ITransactionsRepository _transactionsRepository = new TransactionsRepository();

        public CreditCard GetCreditCardByCardNumber(int cardNumber)
        {
            return _creditCardRepository.SelectCreditCardByCardNumber(cardNumber);
        }

        public bool BlockCreditCard(int cardNumber)
        {
            return _creditCardRepository.UpdateCardToBlock(cardNumber) > 0;
        }

        public BankAccount GetBankAccountByClientId(int clientId)
        {
            return _bankAccountRepository.GetBankAccountByClientId(clientId);
        }

        public BankAccount GetBankAccountByCreditNumber(int creditNumber)
        {
            return _bankAccountRepository.SelectBankAccountByCardNumber(creditNumber);
        }

        public bool IsTransactionUnderLimit(decimal curSum, decimal limit, decimal transaction)
        {
            return (curSum + limit) >= transaction;
        }

        public string CreateTransaction(int from, int to, decimal sum, string category)
        {
            string ret;

            int transactionId = _transactionsRepository.InsertTransaction(from, to, sum, category);
            if (transactionId > 0)
            {
                _bankAccountRepository.UpdatebankAccountFrom(transactionId, sum);
                _bankAccountRepository.UpdatebankAccountTo(transactionId, sum);

                ret = "Transaction was sucssessfull, Have a nice day";
            }
            else
            {
                ret = "Transaction was unsucssessfull";
            }
            return ret;
        }
    }
}