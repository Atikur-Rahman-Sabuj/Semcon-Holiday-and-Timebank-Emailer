using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semcon_Holiday_and_Timebank_Emailer.Models
{
    public class Email
    {
        public String From { get; set; }
        public String To { get; set; }
        public String FromName { get; set; }
        public String ToName { get; set; }
        public String Subject { get; set; }
        public String Body { get; set; }
    }
}
