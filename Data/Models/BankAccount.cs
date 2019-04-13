using System;

namespace Data.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public string IBAN { get; set; }
        public DateTime CreationAccountDate { get; set; }
        public DateTime TerminationDate { get; set; }
        public decimal CurrentSum { get; set; }
        public decimal Limit { get; set; }
    }
}