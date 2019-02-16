using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semcon_Holiday_and_Timebank_Emailer.DataAccess
{
    public class SettingDataAccess
    {
        //Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
        //config.AppSettings.Settings.Remove("SenderEmail");
        //config.AppSettings.Settings.Add("SenderEmail", "tus tus");
        //config.Save(ConfigurationSaveMode.Modified);
        //ConfigurationManager.RefreshSection("appSettings");
        //MessageBox.Show(ConfigurationManager.AppSettings["SenderEmail"]);
        public String GetName()
        {
            return ConfigurationManager.AppSettings["SenderName"];
        }
        public String GetEmail()
        {
            return ConfigurationManager.AppSettings["SenderEmail"];
        }
        public String GetDesignation()
        {
            return ConfigurationManager.AppSettings["SenderDesignation"];
        }
        public DateTime GetDate()
        {
            return DateTime.Parse(ConfigurationManager.AppSettings["Date"]);
        }
        public bool SetSender(String Name, String Email, String Designaion)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config.AppSettings.Settings.Remove("SenderEmail");
                config.AppSettings.Settings.Remove("SenderName");
                config.AppSettings.Settings.Remove("SenderDesignation");
                config.AppSettings.Settings.Add("SenderEmail", Email);
                config.AppSettings.Settings.Add("SenderName", Name);
                config.AppSettings.Settings.Add("SenderDesignation", Designaion);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool SetDate(DateTime date)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config.AppSettings.Settings.Remove("Date");
                config.AppSettings.Settings.Add("Date", date.ToString("dd MMM yyyy"));
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                return true;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
