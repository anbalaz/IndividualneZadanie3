using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;

namespace BankSystem
{
    public class BankManager
    {
        private IBankAccountRepository _bankAccountRepository = new BankAccountRepository();
        private IClientRepository _clientRepository = new ClientRepository();
        ITownRepository _townRepository = new TownRepository();

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
    }
}
