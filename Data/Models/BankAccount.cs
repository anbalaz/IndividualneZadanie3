using System;

namespace Data.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public string IBAN { get; set; }
        public DateTime CreateAccount { get; set; }
        public DateTime DeleteAccount { get; set; }
        public decimal CurrentSum { get; set; }
        public decimal Limit { get; set; }
    }
}