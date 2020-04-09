using System;
using System.Collections.Generic;
using System.Text;

namespace GuavaPay.Domain.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool Enabled { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<Agent> Agents { get; set; }

    }
}
