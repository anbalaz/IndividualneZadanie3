using System;

namespace Data.Models
{
    public class Transactions
    {
        public int Id { get; set; }
        public BankAccount BankAccountSend { get; set; }
        public BankAccount BankAccountReceive { get; set; }
        public string VS { get; set; }
        public string SS { get; set; }
        public string CS { get; set; }
        public string MessageForReceiver { get; set; }
        public DateTime DateOfTransaction { get; set; }
    }
}