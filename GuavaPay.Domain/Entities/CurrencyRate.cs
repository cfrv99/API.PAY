using System;
using System.Collections.Generic;
using System.Text;

namespace GuavaPay.Domain.Entities
{
    public class CurrencyRate
    {
        public int Id { get; set; }
        public decimal SellRate { get; set; }
        public decimal BuyRate { get; set; }
        public DateTime RateDateTime { get; set; }
        public int FromCurrencyId { get; set; }
        public Currency FromCurrency { get; set; }
        public int ToCurrencyId { get; set; }
        public Currency ToCurrency { get; set; }
    }
}
