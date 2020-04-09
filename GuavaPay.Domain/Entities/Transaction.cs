using System;
using System.Collections.Generic;
using System.Text;

namespace GuavaPay.Domain.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Status { get; set; }
        public int SourceAccountId { get; set; }
        public Account SourceAccount { get; set; }
        public int TargetAccountId { get; set; }
        public Account TargetAccount { get; set; }
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public decimal TransactionAmount { get; set; }
        public decimal ComisionAmount { get; set; }
        public string TransactionType { get; set; }
        public string TransactionDescription { get; set; }
        public int TransactionRequestId { get; set; }
        public TransactionRequest TransactionRequest { get; set; }

    }
}
