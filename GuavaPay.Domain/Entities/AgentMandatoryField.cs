using System;
using System.Collections.Generic;
using System.Text;

namespace GuavaPay.Domain.Entities
{
    public class AgentMandatoryField
    {
        public int Id { get; set; }
        public bool NameMandatory { get; set; }
        public bool SurnameMandatory { get; set; }
        public bool LastnameMandatory { get; set; }
        public bool BirthdayMandatory { get; set; }
        public bool DocumentNumberMandatory { get; set; }
        public bool DocumentSeriesMandatory { get; set; }
        public bool DocumentProdDateMandatory { get; set; }
        public bool DocumentEndDateMandatory { get; set; }
        public bool DocumentProdCityMandatory { get; set; }
        public bool DoumentProdCountryMandatory { get; set; }
        public int AgentId { get; set; }
        public Agent Agent { get; set; }
    }
}
