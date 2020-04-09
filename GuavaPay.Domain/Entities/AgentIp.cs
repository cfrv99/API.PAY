using System;
using System.Collections.Generic;
using System.Text;

namespace GuavaPay.Domain.Entities
{
    public class AgentIp
    {
        public int Id { get; set; }
        public string IP { get; set; }
        public int AgentId { get; set; }
        public Agent Agent { get; set; }
    }
}
