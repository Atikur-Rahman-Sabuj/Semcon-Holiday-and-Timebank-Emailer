using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semcon_Holiday_and_Timebank_Emailer.Models
{
    public class Employee
    {
        public String Name { get; set; }
        public String FirstName { get; set; }
        public String SurName { get; set; }
        public String Email { get; set; }
        public String HolidayTakenYTD { get; set; }
        public String RemainingHours { get; set; }
        public String TotalTimebank { get; set; }
        public String ChristmasHours { get; set; }
        public String RemainingAfterChrismasHours { get; set; }
        public String ExtraTextField1 { get; set; }
        public String ExtraTextField2 { get; set; }
    }
}
