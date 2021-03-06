﻿using System;

namespace Data.Models
{
    public class Transactions
    {
        public int Id { get; set; }
        public BankAccount BankAccountTo { get; set; }
        public BankAccount BankAccountFrom { get; set; }
        public string VS { get; set; }
        public string SS { get; set; }
        public string CS { get; set; }
        public string MessageForReceiver { get; set; }
        public decimal MoneyTransaction { get; set; }
        public string Category { get; set; }
        public DateTime DateOfTransaction { get; set; }
    }
}