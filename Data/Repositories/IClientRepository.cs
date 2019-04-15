using Data.Models;
using System.Data;

namespace Data.Repositories
{
    public interface IClientRepository
    {
        int CreateClient(string identityCard, string firstName, string lastName, int town, string street, string streetNumber, string postalCode, string phoneNumber, string email);
        int DeleteClient(int clientId);
        Client GetClientById(int clientId);
        DataSet GetClientSearch(string identityCard);
        int ClientId(string identityCard);
        int ClientUpdate(int clientId, int townId, string identityCard, string firstName, string lastName, string street, string streetNumber, string postalCode, string phoneNumber, string email);
        Client SelectClientByIBAN(string IBAN);
    }
}
