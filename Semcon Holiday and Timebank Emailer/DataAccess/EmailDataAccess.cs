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
        public List<Email> GenerateEmails(List<Employee> employees, String subject, String from,Boolean isHolidayMood, String Date)
        {
            List<Email> emails = new List<Email>();
            foreach (Employee employee in employees)
            {
                Email email = new Email()
                {
                    From = from,
                    To = employee.Email,
                    ToName = employee.Name,
                    Subject = subject+" "+employee.FirstName+" "+employee.SurName,
                    Body = GenerateBody(employee, isHolidayMood, Date)
                };
                emails.Add(email);
            }
            
            return emails;
        }

        public Boolean SendEmails(List<Employee> employees, List<Email> emails, DataGridView dgv, String beginText)
        {
            SettingDataAccess setting = new SettingDataAccess();
            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = true;
            client.Port = 25;
            client.Host = "smtp.semcon.se";
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = false;
            bool sent = true;
            int i = 0;
            foreach (Email email in emails)
            {
                MailAddress From = new MailAddress(setting.GetEmail(), setting.GetName());
                MailAddress To = new MailAddress(email.To, email.ToName);
                MailMessage mailMessage = new MailMessage(From, To);
                mailMessage.Subject = email.Subject;
                mailMessage.Body = AddTexttoBody(employees[i].FirstName, email.Body, beginText);
                //MessageBox.Show(mailMessage.Body);
                try
                {
                    client.Send(mailMessage);
                    dgv.Rows[i++].Cells["Result"].Value = "Sent";
                    //MessageBox.Show("Sent Successful to" + email.To);
                }
                catch (Exception ex)
                {
                    sent = false;
                    dgv.Rows[i++].Cells["Result"].Value = "Not sent";
                    //MessageBox.Show("Sent UN Successful to" + email.To + "\nException: "+ex.Message);
                }
            }
            return sent;
        }

        public String GenerateBody(Employee employee, Boolean isHolidayMood, String Date)
        {
            String Body = "";
            //Body = Body + "Test of editing body" + Environment.NewLine;
            //Body = Body + "Dear " + employee.FirstName+Environment.NewLine;
            if (isHolidayMood)
            {
                Body = Body + "Our Maconomy records show that you have taken "+employee.HolidayTakenYTD+" hours holiday at the end of "+ Date +" from your current year entitlement."+Environment.NewLine+Environment.NewLine;
                Body = Body + "Your remaining balance for the current holiday year is "+employee.RemainingHours+" hours. This balance is not adjusted for the Christmas shutdown so please reserve 3 days to cover Tues 24th (Fri 27th) December through to Tue 31st December 2019 (nb: these dates are subject to change to meet customer requirements)."+Environment.NewLine+Environment.NewLine;

            }
            else
            {
                Body = Body + "Our Maconomy records show that you had a balance of "+employee.TotalTimebank+" hours in Timebank at the end of "+ Date +"." + Environment.NewLine+Environment.NewLine;
                Body = Body + "Please note, if the figure is shown as negative (either in brackets or with a minus sign), this means your Timebank balance is negative and you should rectify the position ASAP."+Environment.NewLine+Environment.NewLine;
            }
            Body = Body + "This email is for your records only, however please feel free to contact me if you have a query with this figure."+Environment.NewLine+Environment.NewLine;
            Body = Body + "Many thanks "+Environment.NewLine+new SettingDataAccess().GetName()+" "+Environment.NewLine+ new SettingDataAccess().GetDesignation();
            return Body;
        }
        public String AddTexttoBody(String Name, String Body, String Text)
        {
            String NewBody = "Dear " + Name +","+ Environment.NewLine+Environment.NewLine;
            if(!Text.Equals(""))
                NewBody = NewBody + Text + ". " + Body;
            else
            {
                NewBody = NewBody + Body;
            }
            return NewBody;
        }
    }
}
