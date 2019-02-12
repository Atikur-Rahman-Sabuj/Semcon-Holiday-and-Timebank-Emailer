using Semcon_Holiday_and_Timebank_Emailer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Semcon_Holiday_and_Timebank_Emailer.DataAccess
{
    public class EmailDataAccess
    {
        public List<Email> GenerateEmails(List<Employee> employees, String subject, String from,Boolean isHolidayMood)
        {
            List<Email> emails = new List<Email>();
            foreach (Employee employee in employees)
            {
                Email email = new Email()
                {
                    From = from,
                    To = employee.Email,
                    Subject = subject,
                    Body = GenerateBody(employee, isHolidayMood)
                };
                emails.Add(email);
            }
            return emails;
        }

        public void SendEmails(List<Email> emails)
        {
            SmtpClient client = new SmtpClient("169.254.1.159");
            foreach (Email email in emails)
            {
                MailMessage completeMail = new MailMessage(email.From, email.To, email.Subject, email.Body);
                try
                {
                    client.Send(completeMail);
                }
                catch (Exception)
                {

                    throw;
                }
                
            }
        }

        public String GenerateBody(Employee employee, Boolean isHolidayMood)
        {
            String Body = "";
            Body = Body + "Dear " + employee.FirstName+"\n";
            if (isHolidayMood)
            {
                Body = Body + "Our Maconomy records show that you had a balance of "+"xxxxxx"+" hours in Timebank at the end of "+"mmmm-yy."+"\n";
                
            }
            else
            {
                Body = Body + "Our Maconomy records show that you had a balance of " + "xxxxxx" + " hours in Timebank at the end of " + "mmmm-yy." + "\n";
            }
            Body = Body + "Please note, if the figure is shown as negative (either in brackets or with a minus sign), this means your Timebank balance is negative and you should rectify the position ASAP.\n";
            Body = Body + "This email is for your records only, however please feel free to contact me if you have a query with this figure.\n";
            Body = Body + "Many thanks \nJill Thurston \nCommercial Finance Manager";
            return Body;
        }
    }
}
