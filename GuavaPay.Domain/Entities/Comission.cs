using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GuavaPay.Domain.Entities
{
    public class Comission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsStatic { get; set; }
        public decimal AmountFrom { get; set; }
        public decimal AmountTo { get; set; }
        public decimal ComissionAmount { get; set; }
        public bool IsPercent { get; set; }
        public decimal ComissionPercent { get; set; }
        public bool IsGuava { get; set; }
        public bool Active { get; set; }
        public bool ToSender { get; set; }
        public decimal AgentComissionAmount { get; set; }
        public decimal AgentComissionPercent { get; set; }
        [ForeignKey("ToCountry")]
        public int ToCountryId { get; set; }
        public Country ToCountry { get; set; }
        [ForeignKey("FromCountry")]
        public int FromCountryId { get; set; }
        public Country FromCountry { get; set; }
        public ICollection<AgentComission> AgentComissions { get; set; }

    }
}
