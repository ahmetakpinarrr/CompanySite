using System;
using System.Collections.Generic;

#nullable disable

namespace CompanySite.Models
{
    public partial class CustomerMessage
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerSubject { get; set; }
        public string CustomerMessage1 { get; set; }
        public int? ContactLocation { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
