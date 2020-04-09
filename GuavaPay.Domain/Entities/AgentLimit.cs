using System;
using System.Collections.Generic;
using System.Text;

namespace GuavaPay.Domain.Entities
{
    public class AgentLimit
    {
        public int Id { get; set; }
        public int AgentId { get; set; }
        public Agent Agent { get; set; }
        public int LimitId { get; set; }
        public Limit Limit { get; set; }
        public decimal UsedAmount { get; set; }
        public DateTime NextRenewalDate { get; set; }
    }
}
