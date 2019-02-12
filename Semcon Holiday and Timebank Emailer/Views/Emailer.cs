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

namespace Semcon_Holiday_and_Timebank_Emailer
{
    public partial class Emailer : Form
    {
        String FilePath;
        String EmailSubject;
        List<Employee> Employees;
        Boolean HolidayMood;
        public Emailer()
        {
            InitializeComponent();
            dgvEmployees.AutoGenerateColumns = false;

        }

        private void btnSelectCsv_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                FilePath = openFileDialog1.FileName;
                EmailSubject = openFileDialog1.SafeFileName.Substring(0, openFileDialog1.SafeFileName.Length - 4);
                Employees = new EmployeeDataAccess().BindFileDataToModel(FilePath);
                Utilities.BindListToGridView(Employees, dgvEmployees);
                ShowHideControls(true);
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
            }
            else
            {
                HolidayMood = false;
            }
            btnSelectCsv.Visible = true;
        }

        private void btnSendEmails_Click(object sender, EventArgs e)
        {
            List<Email> emails = new EmailDataAccess().GenerateEmails(Employees, EmailSubject, "jill.thurston@semcon.com", HolidayMood);
            try
            {
                new EmailDataAccess().SendEmails(emails);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            
        }

        private void Emailer_Load(object sender, EventArgs e)
        {
            this.Height = 590;
            this.Width = 993;
            ShowHideControls(false);
        }
        private void ShowHideControls(Boolean showHide)
        {
            btnSelectCsv.Visible = showHide;
            dgvEmployees.Visible = showHide;
            btnSendEmails.Visible = showHide;
        }

        private void dgvEmployees_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvEmployees.Rows[e.RowIndex].Cells["colSerialNo"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
