using System;
using System.Collections.Generic;
using System.Text;

namespace GuavaPay.Domain.Entities
{
    public class CountryLimit
    {
        public int Id { get; set; }
        public decimal UsedAmount { get; set; }
        public DateTime NextRenewalDate { get; set; }
        public int FromCountryId { get; set; }
        public Country FromCountry { get; set; }
        public int ToCountryId { get; set; }
        public Country ToCountry { get; set; }
        public int LimitId { get; set; }
        public Limit Limit { get; set; }
        public int AgentId { get; set; }
        public Agent Agent { get; set; }
    }
}
