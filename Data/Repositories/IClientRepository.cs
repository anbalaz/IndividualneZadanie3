namespace Data.Repositories
{
    public interface IClientRepository
    {
        int CreateClient(string identityCard, string firstName, string lastName, int town, string street, string streetNumber, string postalCode, string phoneNumber, string email);
        int DeleteClient(int clientId);
    }
}
