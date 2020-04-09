using System;
using System.Collections.Generic;
using System.Text;

namespace GuavaPay.Domain.Entities
{
    public class AgentComission
    {
        public int Id { get; set; }
        public int AgentId { get; set; }
        public Agent Agent { get; set; }
        public int ComissionId { get; set; }
        public Comission Comission { get; set; }
         
    }
}
