﻿using Data.Models;
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

        public String UpdateClientAndBankAccount(int clientId, int townId, string identityCard, string firstName, string lastName, string street, string streetNumber, string postalCode, string phoneNumber, string email, decimal limit)
        {
            string ret;
            int clientUpdate = _clientRepository.ClientUpdate(clientId, townId, identityCard, firstName, lastName, street, streetNumber, postalCode, phoneNumber, email);
            int bankUpdate = _bankAccountRepository.UpdatebankAccount(clientId,limit);

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
            return _townRepository.GeListData();
        }

        public DataSet GetSearchedClients(string searchString)
        {
            return _clientRepository.GetClientSearch(searchString);
        }

        public Client GetClientById(int clientId)
        {
            return _clientRepository.GetClientById(clientId);
        }

        public int ClientId(string identityCard)
        {
            return _clientRepository.ClientId(identityCard);

        }

        public BankAccount GetBankAccountByClientId(int clientId)
        {
            return _bankAccountRepository.GetBankAccountByClientId(clientId);

        }

        public List<CreditCard> GetCreditCardListByClientId(int clientId)
        {
            return _creditCardRepository.GetCreditCardListByClientId(clientId);
        }

        public DataSet GetTransactionsByClientId(int clientId)
        {
            return _transactionsRepository.GetTransactionsByClientId(clientId);
        }

        public DataSet GetAllTransactions()
        {
            return _transactionsRepository.GetAllTransactions();
        }

        public String CloseBankAccount(int clientId)
        {
            string ret;
            if (_bankAccountRepository.CloseBankAccount(clientId) > 0)
            {
                ret = "Account has been terminated";
            }
            else
            {
                ret = "Cant close account";
            }
            return ret;
        }
    }
}
