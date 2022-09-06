using System;
using System.Collections.Generic;

namespace PasswordManager.Models
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public int UserId { get; set; }
        public string AccountName { get; set; } = null!;
        public string AccountUsername { get; set; } = null!;
        public string? AccountPassword { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
