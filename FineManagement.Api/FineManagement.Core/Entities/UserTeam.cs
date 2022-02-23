﻿namespace FineManagement.Core.Entities
{
    public class UserTeam
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public User? User { get; set; }
        public Team? Team { get; set; }
        public virtual ICollection<Transaction>? Transactions { get; set; }
        public virtual ICollection<Fine>? Fines { get; set; }
    }
}
