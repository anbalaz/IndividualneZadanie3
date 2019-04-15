using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformerBank
{
    public class AtmManager
    {
        private ICreditCardRepository _creditCardRepository = new CreditCardRepository();

        public CreditCard GetCreditCardByCardNumber(int cardNumber)
        {
            return _creditCardRepository.SelectCreditCardByCardNumber(cardNumber);
        }
    }
}
