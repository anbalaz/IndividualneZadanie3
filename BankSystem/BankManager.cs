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

        public List<Town> GetListOfTowns()
        {
            return _townRepository.GeListData();
        }

        public DataSet GetSearchedClients(string searchString)
        {
            return _clientRepository.GetClientSearch(searchString);
        }

        public Client GetClientById(string identityCardNumber)
        {
            return _clientRepository.GetClientById(identityCardNumber);
        }

        public string ClientId(string identityCard)
        {
            return _clientRepository.ClientId(identityCard);

        }

        public BankAccount GetBankAccountByClientId(string identityCard)
        {
            return _bankAccountRepository.GetBankAccountByClientId(identityCard);

        }

        public List<CreditCard> GetCreditCardListByClientId(string identityCard)
        {
            return _creditCardRepository.GetCreditCardListByClientId(identityCard);
        }

    }
}
