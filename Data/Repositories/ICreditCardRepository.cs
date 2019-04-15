using Data.Models;
using System.Collections.Generic;
using System.Data;

namespace Data.Repositories
{
    public interface ICreditCardRepository
    {
        List<CreditCard> SelectCreditCardListByClientId(int clientId);
        DataSet SelectCreditCardByCardByClientId(int clientId);
        CreditCard SelectCreditCardByCardNumber(int cardNumber);
        int InsertCreditCardByBankAccountId(int bankAccountId, int cardNumber, int cardPassword);
        int UpdateCardBlockUnblock(int cardNumber,int blockUnblock);
    }
}
