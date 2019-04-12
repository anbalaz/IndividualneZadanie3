using System;

namespace Data.Models
{
    public class CreditCard
    {
        public int Id { get; set; }
        public BankAccount BankAccount { get; set; }
        public DateTime CreationCardDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsCardBlocked { get; set; }
        public string PasswordCard { get; set; }
    }
}