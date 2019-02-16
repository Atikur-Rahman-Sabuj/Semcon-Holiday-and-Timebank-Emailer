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
    public partial class SplashScreen : Form
    {
        int start = 0;
        public SplashScreen()
        {
            InitializeComponent();
            label2.UseMnemonic = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            start++;
            if(start == 3)
            {
                new Emailer().Show();
                timer1.Stop();
                this.Hide();
            }
        }
    }
}
