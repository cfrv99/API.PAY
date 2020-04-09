using System;
using System.Collections.Generic;
using System.Text;

namespace GuavaPay.Domain.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public decimal AvailableAmount { get; set; }
        public decimal BlockedAmount { get; set; }

        public int AccountTypeId { get; set; }
        public AccountType AccountType { get; set; }
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public int AgentId { get; set; }
        public Agent Agent { get; set; }
        public int AccountStatusId { get; set; }
        public AccountStatus AccountStatus { get; set; }
        public ICollection<Transaction> SourceTransactions { get; set; }
        public ICollection<Transaction> TargetTransaction { get; set; }
    }
}
