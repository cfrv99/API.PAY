using System;
using System.Collections.Generic;
using System.Text;

namespace GuavaPay.Domain.Entities
{
    public class AccountStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Account> Accounts { get; set; }

    }
}
