using System;
using System.Collections.Generic;
using System.Text;

namespace GuavaPay.Domain.Entities
{
    public class Agent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public string Address { get; set; }
        public bool AllowSend { get; set; }
        public bool AllowReceive { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }

        public ICollection<AgentLimit> AgentLimits { get; set; }
        public ICollection<AgentComission> AgentComissions { get; set; }
        public ICollection<CountryLimit> CountryLimits { get; set; }
        public ICollection<AgentUser> AgentUsers { get; set; }
        public ICollection<AgentCountry> AgentCountries { get; set; }
        public ICollection<AgentIp> AgentIps { get; set; }
        public ICollection<AgentMandatoryField> AgentMandatoryFields { get; set; }
        public ICollection<Account> Accounts { get; set; }


    }
}
