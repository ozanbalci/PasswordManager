using System;
using System.Collections.Generic;

namespace PasswordManager.Models
{
    public partial class User
    {
        public User()
        {
            Accounts = new HashSet<Account>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public int UserPin { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
