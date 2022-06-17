using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deltaware2
{
    public partial class Exam : MaterialForm
    {
        public string time;
        public int examTime;
        public string examTimeText;
        public int delta;

        int timerInterval = 100;
        public Exam()
        {
            reDesign();
            InitializeComponent();
        }

        private void Exam_Load(object sender, EventArgs e)
        {
            examTime = Information.examManager.examTime;
            updateText();
            startTimer();
            examTimer.Start();
        }
        private void finishExam_Click(object sender, EventArgs e)
        {
            finishedExam();
        }

        public void updateText()
        {
            examTimeText = examTime + " Dakika";
            this.Text = "Kalan Süre: "+ examTimeText;
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

        private void examTimer_Tick(object sender, EventArgs e)
        {
            delta++;
            if (delta == 600)
            {
                delta = 0;
                examTime = examTime - 1;
                updateText();
            }
        }
        public void finishedExam()
        {
            DialogResult dialogResult = MessageBox.Show("Sınavı şimdi bitirmek istediğinizden emin misiniz? Kalan süre: " + examTimeText, "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                examTimer.Stop();
                this.Text = "Sınav bitirildi.";
                finishExam.Enabled = false;
                Information.dataManager.changeVeriable(true);
                infoLabel.Text = "Sınav danışmanına bildirin.";
            }
        }
    }
}