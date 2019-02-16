using Semcon_Holiday_and_Timebank_Emailer.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    ToName = employee.Name,
                    Subject = subject,
                    Body = GenerateBody(employee, isHolidayMood)
                };
                emails.Add(email);
            }
            
            return emails;
        }

        public Boolean SendEmails(List<Email> emails)
        {
            SettingDataAccess setting = new SettingDataAccess();
            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = true;
            //client.Credentials = new System.Net.NetworkCredential("adm-sx27186", "Laxmi2121");
            client.Port = 25;
            client.Host = "smtp.semcon.se";
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = false;
            bool sent = true;
            foreach (Email email in emails)
            {
                MailAddress From = new MailAddress(setting.GetEmail(), setting.GetName());
                MailAddress To = new MailAddress(email.To, email.ToName);
                MailMessage mailMessage = new MailMessage(From, To);
                mailMessage.Subject = email.Subject;
                mailMessage.Body = email.Body;
                try
                {
                    client.Send(mailMessage);
                    //MessageBox.Show("Sent Successful to" + email.To);
                }
                catch (Exception ex)
                {
                    sent = false;
                    //MessageBox.Show("Sent UN Successful to" + email.To + "\nException: "+ex.Message);
                }
            }
            return sent;
        }

        public String GenerateBody(Employee employee, Boolean isHolidayMood)
        {
            String Body = "";
            Body = Body + "Dear " + employee.FirstName+Environment.NewLine;
            if (isHolidayMood)
            {
                Body = Body + "Our Maconomy records show that you had a balance of "+employee.RemainingHours+" hours in Timebank at the end of "+new SettingDataAccess().GetDate().ToString("MMMM-yy")+"."+Environment.NewLine;
                
            }
            else
            {
                Body = Body + "Our Maconomy records show that you had a balance of " + employee.RemainingHours + " hours in Timebank at the end of " + "Test." + Environment.NewLine;
            }
            Body = Body + "Please note, if the figure is shown as negative (either in brackets or with a minus sign), this means your Timebank balance is negative and you should rectify the position ASAP."+Environment.NewLine;
            Body = Body + "This email is for your records only, however please feel free to contact me if you have a query with this figure."+Environment.NewLine;
            Body = Body + "Many thanks "+Environment.NewLine+new SettingDataAccess().GetName()+" "+Environment.NewLine+ new SettingDataAccess().GetDesignation();
            return Body;
        }
    }
}
