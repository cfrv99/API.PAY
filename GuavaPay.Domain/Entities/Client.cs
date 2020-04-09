using System;
using System.Collections.Generic;
using System.Text;

namespace GuavaPay.Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }
        public string DocumentSeries { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime DocumentProdDate { get; set; }
        public DateTime DocumentEndDate { get; set; }
        public string DocumentProdCity { get; set; }
        public string DocumentProdCountry { get; set; }
        public string ReceiverPhone { get; set; }
        public string SenderPhone { get; set; }
        public ICollection<ClientLimit> ClientLimits { get; set; }
    }
}
