using Data.Models;
using System.Data;

namespace Data.Repositories
{
    public interface IClientRepository
    {
        int CreateClient(string identityCard, string firstName, string lastName, int town, string street, string streetNumber, string postalCode, string phoneNumber, string email);
        int DeleteClient(int clientId);
        Client SelectClientById(int clientId);
        DataSet SelectClientSearch(string identityCard);
        int SelectClientId(string identityCard);
        int SelectClientUpdate(int clientId, int townId, string identityCard, string firstName, string lastName, string street, string streetNumber, string postalCode, string phoneNumber, string email);
        Client SelectClientByIBAN(string IBAN);
        DataSet SelectNewclients();
    }
}