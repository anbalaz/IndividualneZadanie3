using Data.Models;
using System.Collections.Generic;

namespace Data.Repositories
{
    public interface ICreditCardRepository
    {
        List<CreditCard> GeListData();
        List<CreditCard> GetCreditCardListByClientId(int clientId);
    }
}
