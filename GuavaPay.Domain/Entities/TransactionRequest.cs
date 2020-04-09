using System;
using System.Collections.Generic;
using System.Text;

namespace GuavaPay.Domain.Entities
{
    public class TransactionRequest
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public bool IsApproved { get; set; }
        public bool IsDelivered { get; set; }
        public decimal ConversionAmount { get; set; }
        public string RNN { get; set; }
        public string AgentReference { get; set; }
        public string AgentCode { get; set; }
        public string AgentMessage { get; set; }
        public string Code { get; set; }
        public int RC { get; set; }

        public int FromAgentId { get; set; }
        public Agent FromAgent { get; set; }
        public int? ToAgentId { get; set; }
        public Agent ToAgent { get; set; }
        public int FromCityId { get; set; }
        public City FromCity { get; set; }
        public int ToCityId { get; set; }
        public City ToCity { get; set; }
        public int FromClientId { get; set; }
        public Client FromClient { get; set; }
        public int ToClientId { get; set; }
        public Client ToClient { get; set; }
        public int SenderCurrencyId { get; set; }
        public Currency SenderCurrency { get; set; }
        public ICollection<Transaction> Transactions { get; set; }


    }
}
