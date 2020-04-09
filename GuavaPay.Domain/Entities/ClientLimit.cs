using System;
using System.Collections.Generic;
using System.Text;

namespace GuavaPay.Domain.Entities
{
    public class ClientLimit
    {
        public int Id { get; set; }
        public bool IsSender { get; set; }
        public decimal UsedAmount { get; set; }
        public DateTime NextRenewalDate { get; set; }
        public int LimitId { get; set; }
        public Limit Limit { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
