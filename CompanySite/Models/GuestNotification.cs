using System;
using System.Collections.Generic;

#nullable disable

namespace CompanySite.Models
{
    public partial class GuestNotification
    {
        public int Id { get; set; }
        public string GuestMail { get; set; }
        public DateTime? CreateDate { get; set; }
        public byte? IsNoticationActive { get; set; }
    }
}
