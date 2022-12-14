using System;
using System.Collections.Generic;

#nullable disable

namespace CompanySite.Models
{
    public partial class Guest
    {
        public int Id { get; set; }
        public string GuestName { get; set; }
        public string GuestSurname { get; set; }
        public string GuestEmail { get; set; }
        public string GuestPhone { get; set; }
        public string GuestMessage { get; set; }
        public DateTime? CreatedDate { get; set; }
        public byte? Showed { get; set; }
        public byte? Answered { get; set; }
    }
}
