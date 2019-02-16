using Semcon_Holiday_and_Timebank_Emailer.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semcon_Holiday_and_Timebank_Emailer.Views
{
    public partial class Setting : Form
    {
        SettingDataAccess settingDataAccess;
        public Setting()
        {
            InitializeComponent();
            settingDataAccess = new SettingDataAccess();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            tbxName.Text = settingDataAccess.GetName();
            tbxEmail.Text = settingDataAccess.GetEmail();
            tbxDesignation.Text = settingDataAccess.GetDesignation();
            dateTimePicker1.Value = settingDataAccess.GetDate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(settingDataAccess.SetSender(tbxName.Text, tbxEmail.Text, tbxDesignation.Text))
            {
                MessageBox.Show("Saved successfully");
            }
            else
            {
                MessageBox.Show("Could no save");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (settingDataAccess.SetDate(dateTimePicker1.Value))
            {
                MessageBox.Show("Saved successfully");
            }
            else
            {
                MessageBox.Show("Could no save");
            }
        }
    }
}
