using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanySite.Helpers {
    public class EmailSendModel {
        public string Subject { get; set; }
        public string MailContext { get; set; }
        public string MailAddress { get; set; }
        public int RegisterId { get; set; }
    }
}
