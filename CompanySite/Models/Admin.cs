using System;
using System.Collections.Generic;

#nullable disable

namespace CompanySite.Models
{
    public partial class Admin
    {
        public int Id { get; set; }
        public string AdminUserName { get; set; }
        public string AdminPassword { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
