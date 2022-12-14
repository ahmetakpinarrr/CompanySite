using System;
using System.Collections.Generic;

#nullable disable

namespace CompanySite.Models
{
    public partial class CustomersProcce
    {
        public int Id { get; set; }
        public string CustomerTitle { get; set; }
        public string CustomerOfficialName { get; set; }
        public string CustomerJobType { get; set; }
        public string CustomerWebSite { get; set; }
        public string AddressDetail { get; set; }
        public string CustomerDesription { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public byte? IsDiscussed { get; set; }
        public DateTime? WhenDiscussed { get; set; }
        public int? CustomerLevel { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; }
    }
}
