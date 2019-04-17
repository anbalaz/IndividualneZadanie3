using Data.Models;
using Data.Repositories;
using System.Security.Cryptography;
using System.Text;

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
        /// <summary>
        /// chceks if sum you want to take out of account is not over client s limit
        /// </summary>
        /// <param name="curSum"></param>
        /// <param name="limit"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public bool AccessCreditCard(int cardNumber, int blockUnblock)
        {
            return _creditCardRepository.UpdateCardBlockUnblock(cardNumber, blockUnblock) > 0;
        }

        public BankAccount GetBankAccountByClientId(int clientId)
        {
            return _bankAccountRepository.SelectBankAccountByClientId(clientId);
        }

        public BankAccount GetBankAccountByCreditNumber(int creditNumber)
        {
            return _bankAccountRepository.SelectBankAccountByCardNumber(creditNumber);
        }
        /// <summary>
        /// chceks if sum you want to take out of account is not over client s limit
        /// </summary>
        /// <param name="curSum"></param>
        /// <param name="limit"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public bool IsTransactionUnderLimit(decimal curSum, decimal limit, decimal transaction)
        {
            return (curSum + limit) >= transaction;
        }
        /// <summary>
        /// if transaction is successfull but there is problem with accounts it delete last transaction
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="sum"></param>
        /// <param name="category"></param>
        /// <param name="VS"></param>
        /// <param name="CS"></param>
        /// <param name="SS"></param>
        /// <param name="MessageForReceiver"></param>
        /// <returns>returns statement how did the trasaction go</returns>
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

        public string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

    }
}