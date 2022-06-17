using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deltaware2
{
    public partial class Login : MaterialForm
    {
        public string time;
        public int timerInterval = 100;
        public Login()
        {
            reDesign();
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            startTimer();
        }

        private void informationButton_Click(object sender, EventArgs e)
        {
            Information information = new Information();
            information.Show();
            this.Hide();
            timer.Stop();
        }

        public void startTimer()
        {
            timer.Interval = timerInterval;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now.ToString();
            dateTimeLabel.Text = time;
        }
    }
}
