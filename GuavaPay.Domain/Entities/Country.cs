using System;
using System.Collections.Generic;
using System.Text;

namespace GuavaPay.Domain.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool Enabled { get; set; }
        public int CountryCode { get; set; }
        public ICollection<City> Cities { get; set; }
        public ICollection<AgentCountry> AgentCountries { get; set; }
        public ICollection<Currency> Currencies { get; set; }
        public ICollection<CountryCurrencyTransfer> CountryCurrencyTransfers { get; set; }
        public ICollection<Comission> ComissionsFrom { get; set; }
        public ICollection<Comission> ComissionsTo { get; set; }
        public ICollection<CountryLimit> FromCountryLimits { get; set; }
        public ICollection<CountryLimit> ToCountryLimits { get; set; }
    }
}
