using System;
using System.Collections.Generic;
using System.Text;

namespace GuavaPay.Domain.Entities
{
    public class Limit
    {
        public int Id { get; set; }
        public int NumberOfDay { get; set; }
        public decimal AmountLimit { get; set; }
        public bool Active { get; set; }
        public ICollection<AgentLimit> AgentLimits { get; set; }
        public ICollection<ClientLimit> ClientLimits { get; set; }
        public ICollection<CountryLimit> CountryLimits { get; set; }

    }
}
