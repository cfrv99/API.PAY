using System;
using System.Collections.Generic;
using System.Text;

namespace GuavaPay.Domain.Entities
{
    public class Currency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool Enabled { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<CountryCurrencyTransfer> CountryCurrencyTransfers { get; set; }
        public ICollection<Account> Accounts { get; set; }
        public ICollection<CurrencyRate> FromCurrencyRates { get; set; }
        public ICollection<CurrencyRate> ToCurrencyRates { get; set; }
        public ICollection<Transaction> Transactions { get; set; }

    }
}
