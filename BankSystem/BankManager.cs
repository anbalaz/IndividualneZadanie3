using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data;

namespace BankSystem
{
    public class BankManager
    {
        private IBankAccountRepository _bankAccountRepository = new BankAccountRepository();
        private IClientRepository _clientRepository = new ClientRepository();
        private ITownRepository _townRepository = new TownRepository();
        private ICreditCardRepository _creditCardRepository = new CreditCardRepository();
        private ITransactionsRepository _transactionsRepository = new TransactionsRepository();
        public const int BANK_IDENTIY = 1;

        public String CreateClientAndBankAccount(string identityCard,
                                                string firstName,
                                                string lastName,
                                                int town,
                                                string street,
                                                string streetNumber,
                                                string postalCode,
                                                string phoneNumber,
                                                string email,
                                                string IBAN,
                                                decimal limit)
        {
            string ret;
            int clientId = _clientRepository.CreateClient(identityCard, firstName, lastName, town, street, streetNumber, postalCode, phoneNumber, email);
            if (clientId != 0)
            {
                if (_bankAccountRepository.CreateBankAccount(clientId, IBAN, limit) > 0)
                {
                    ret = "Client and BankAccount were Created";
                }
                else
                {
                    if (_clientRepository.DeleteClient(clientId) > 0)
                    {
                        ret = "There is a problem with  bankAccount, please check the fields";
                    }
                    else
                    {
                        ret = "The problem occured, please call system administrator";
                    }
                }
            }
            else
            {
                ret = "There was some problem with Creating Client";
            }
            return ret;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="townId"></param>
        /// <param name="identityCard"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="street"></param>
        /// <param name="streetNumber"></param>
        /// <param name="postalCode"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        /// <param name="limit"></param>
        /// <returns>returns strng about how if was the update successfull or where it failed</returns>
        public String UpdateClientAndBankAccount(int clientId, int townId, string identityCard, string firstName, string lastName, string street, string streetNumber, string postalCode, string phoneNumber, string email, decimal limit)
        {
            string ret;
            int clientUpdate = _clientRepository.SelectClientUpdate(clientId, townId, identityCard, firstName, lastName, street, streetNumber, postalCode, phoneNumber, email);
            int bankUpdate = _bankAccountRepository.UpdatebankAccount(clientId, limit);

            if (clientUpdate > 0 && bankUpdate > 0)
            {
                ret = "Client and BankAccount were updated";
            }
            else if (clientUpdate == 0 && bankUpdate == 0)
            {
                ret = "Client and BankAccount were not updated";

            }
            else if (clientUpdate > 0)
            {
                ret = "Client was updated but BankAccount was not updated";
            }
            else
            {
                ret = "BankAccount was updated but Client was not updated";
            }
            return ret;
        }

        public List<Town> GetListOfTowns()
        {
            return _townRepository.SelectListData();
        }
        /// <summary>
        /// Search through clientIdentityCard, IBAN and LastName
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public DataSet GetSearchedClients(string searchString)
        {
            return _clientRepository.SelectClientSearch(searchString);
        }

        public Client GetClientById(int clientId)
        {
            return _clientRepository.SelectClientById(clientId);
        }

        public int ClientId(string identityCard)
        {
            return _clientRepository.SelectClientId(identityCard);

        }

        public BankAccount GetBankAccountByClientId(int clientId)
        {
            return _bankAccountRepository.SelectBankAccountByClientId(clientId);
        }

        public List<CreditCard> GetCreditCardListByClientId(int clientId)
        {
            return _creditCardRepository.SelectCreditCardListByClientId(clientId);
        }

        public DataSet GetCreditCardsByClientId(int clientId)
        {
            return _creditCardRepository.SelectCreditCardByCardByClientId(clientId);
        }

        public DataSet GetTransactionsByClientId(int clientId)
        {
            return _transactionsRepository.SelectTransactionsByClientId(clientId);
        }

        public DataSet GetAllTransactions()
        {
            return _transactionsRepository.SelectAllTransactions();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns>returns string if the closing ws succsessfull</returns>
        public String CloseBankAccount(int clientId)
        {
            string ret;
            if (_bankAccountRepository.CloseBankAccount(clientId) > 0)
            {
                ret = "Account has been terminated";
            }
            else
            {
                ret = "Can not close account";
            }
            return ret;
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
        public String CreateTransaction(int from, int to, decimal sum, string category, string VS, string CS, string SS, string MessageForReceiver)
        {
            string ret;

            int transactionId = _transactionsRepository.InsertTransaction(from, to, sum, category);
            if (transactionId > 0)
            {
                _bankAccountRepository.UpdatebankAccountFrom(transactionId, sum);
                _bankAccountRepository.UpdatebankAccountTo(transactionId, sum);

                if (!VS.Equals(string.Empty))
                {
                    _transactionsRepository.UpdateMessage("VS", transactionId, VS);
                }
                if (!CS.Equals(string.Empty))
                {
                    _transactionsRepository.UpdateMessage("CS", transactionId, CS);
                }
                if (!SS.Equals(string.Empty))
                {
                    _transactionsRepository.UpdateMessage("SS", transactionId, SS);
                }
                if (!MessageForReceiver.Equals(string.Empty))
                {
                    _transactionsRepository.UpdateMessage("MessageForReceiver", transactionId, MessageForReceiver);
                }
                ret = "Transaction was sucssessfull";
            }
            else
            {
                _transactionsRepository.DeleteTransaction(transactionId);
                ret = "Transaction was unsucssessfull";
            }
            return ret;
        }
        /// <summary>
        /// blocks or unblocks the card -0 unblocks, 1- blocks
        /// </summary>
        /// <param name="cardNumber"></param>
        /// <param name="blockUnblock"></param>
        /// <returns></returns>
        public bool AccessCreditCard(int cardNumber, int blockUnblock)
        {
            return _creditCardRepository.UpdateCardBlockUnblock(cardNumber, blockUnblock) > 0;
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

        public Client GetClientByIBAN(string IBAN)
        {
            return _clientRepository.SelectClientByIBAN(IBAN);
        }

        public BankAccount GetBankAccountByIBAN(string IBAN)
        {
            return _bankAccountRepository.SelectBankAccountByIBAN(IBAN);
        }

        public string CreateCreditCardByAccountId(int bankAccountId)
        {
            string ret = "Card was not created";

            Random random = new Random();
            int password = random.Next(1000, 9999);
            int cardNumber = random.Next(10000000, 99999999);
            if (_creditCardRepository.InsertCreditCardByBankAccountId(bankAccountId, cardNumber, password) > 0)
            {
                ret = $"Card was  created, password is {password}";
            }
            return ret;
        }

        public decimal GetSumOfMoneyOnAccounts()
        {
            return _bankAccountRepository.SelectSumOfMoneyOnAccounts();
        }

        public int GetCountOfClients()
        {
            return _bankAccountRepository.SelectCountOfClients();
        }

        public DataSet GetTopTowns()
        {
            return _townRepository.SelectTopTowns();
        }

        public DataSet GetTopClients()
        {
            return _bankAccountRepository.SelectTopAccounts();
        }

        public DataSet GetNewclients()
        {
            return _clientRepository.SelectNewclients();
        }
        public String UpdateCardNewPassword(int password, int cardNumber)
        {
            return (_creditCardRepository.UpdateCardNewPassword(password, cardNumber) > 0) ? $"Password was changed to {password}" : "Password was not changed!";

        }

    }
}