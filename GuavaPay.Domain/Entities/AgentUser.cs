using System;
using System.Collections.Generic;
using System.Text;

namespace GuavaPay.Domain.Entities
{
    public class AgentUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int AgentId { get; set; }
        public Agent Agent { get; set; }
    }
}
