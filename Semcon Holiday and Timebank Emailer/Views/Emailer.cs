using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Semcon_Holiday_and_Timebank_Emailer.Models;
using Semcon_Holiday_and_Timebank_Emailer.DataAccess;
using System.Net.Mail;
using System.Configuration;
using Semcon_Holiday_and_Timebank_Emailer.Views;
using System.Threading;

namespace Semcon_Holiday_and_Timebank_Emailer
{
    public partial class Emailer : Form
    {
        String FilePath;
        String EmailSubject;
        List<Employee> Employees;
        List<Email> Emails;
        Boolean HolidayMood;
        int EmailIndex;
        public Emailer()
        {
            InitializeComponent();
        }
        

        private void btnSelectCsv_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                FilePath = openFileDialog1.FileName;
                EmailSubject = openFileDialog1.SafeFileName.Substring(0, openFileDialog1.SafeFileName.Length - 4);
                Employees = new EmployeeDataAccess().BindFileDataToModel(FilePath);
                Emails = new EmailDataAccess().GenerateEmails(Employees, EmailSubject, "jill.thurston@semcon.com", HolidayMood);
                Utilities.BindListToGridView(Employees, dgvEmployees);
                for (int i = 0; i < Employees.Count; i++)
                {
                    dgvEmployees.Rows[i].Cells[0].Value = i+1;
                }
                ShowHideControls(true);
                tbxEmail.Text = "";
                tbxSubject.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                dgvEmployees.Visible = false;
                btnSendEmails.Visible = false;
            }
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.Equals(0))
            {
                HolidayMood = true;
                //setting part
                //Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                //config.AppSettings.Settings.Remove("SenderEmail");
                //config.AppSettings.Settings.Add("SenderEmail", "tus tus");
                //config.Save(ConfigurationSaveMode.Modified);
                //ConfigurationManager.RefreshSection("appSettings");
                //MessageBox.Show(ConfigurationManager.AppSettings["SenderEmail"]);
            }
            else
            {
                HolidayMood = false;
            }
            
            btnSelectCsv.Visible = true;
        }

        private void btnSendEmails_Click(object sender, EventArgs e)
        {
            //List<Email> emails = new EmailDataAccess().GenerateEmails(Employees, EmailSubject, "jill.thurston@semcon.com", HolidayMood);
            if(new EmailDataAccess().SendEmails(Emails))
            {
                MessageBox.Show("Email send successfully.");
            }
            else
            {
                MessageBox.Show("Could not send email.");
            }
        
        }

        private void Emailer_Load(object sender, EventArgs e)
        {
            dgvEmployees.AutoGenerateColumns = false;
            this.Height = 590;
            this.Width = 993;
            ShowHideControls(false);
        }
        private void ShowHideControls(Boolean showHide)
        {
            btnSelectCsv.Visible = showHide;
            dgvEmployees.Visible = showHide;
            btnSendEmails.Visible = showHide;
            btnSave.Visible = showHide;
            tbxEmail.Visible = showHide;
            tbxSubject.Visible = showHide;
            label1.Visible = showHide;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Emails[EmailIndex].Body = tbxEmail.Text;
            Emails[EmailIndex].Subject = tbxSubject.Text;
            MessageBox.Show("Saved Successfully");
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                EmailIndex = e.RowIndex;
                tbxEmail.Text = Emails[EmailIndex].Body;
                tbxSubject.Text = Emails[EmailIndex].Subject;
            }
            catch (Exception)
            {

                
            }
            
        }

        private void Emailer_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Do you want to close the application?", "Confirm",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);
        }
    }
}
