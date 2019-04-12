namespace Data.Models
{
    public class Client
    {
        public int Id { get; set; }
        public int IdBankAccount { get; set; }
        public string IdentityCard { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int IdTown { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string PostalCode { get; set; }
        public int IdCountry { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}