using MaterialSkin.Controls;
using System;
using System.IO;
using System.IO.Compression;
namespace deltaware2
{
    public partial class Information : MaterialForm
    {
        public string time;
        public string[] items = new string[7];
        public string examDownloadLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "exam.zip");
        public string examDesktopLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "");
        public static ExamManager examManager = new ExamManager();
        public static StudentManager studentManager = new StudentManager();
        public static DataManager dataManager = new DataManager();
        public int timerInterval = 100;
        public Information()
        {
            reDesign();
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            startTimer();
        }

        private void startExamButton_Click(object sender, EventArgs e)
        {
            downloadExam();
            createStudent();
            createExamFiles();
            Exam exam = new Exam();
            exam.Show();
            this.Hide();
            timer.Stop();
        }

        public void createExamFiles()
        {
            examDesktopLocation += "\\" + studentManager.grade + "_" + studentManager.number + "_" + studentManager.name + "_" + studentManager.surname + "\\";
            try
            {
                if (!Directory.Exists(examDesktopLocation))
                {
                    Directory.CreateDirectory(examDesktopLocation);
                }
            } catch (Exception)
            {
                MaterialMessageBox.Show("Klasör oluşurken hata oluştu. Yöneticiye bildirin.");
            }
            try {
                ZipFile.ExtractToDirectory(examManager.downloadLocation, examDesktopLocation);
            }catch (Exception)
            {
                MaterialMessageBox.Show("Zip çıktısı alınırken hata oluştu. Yöneticiye bildirin.");
            }
        }

        public void createStudent()
        {
            if (adTextBox.Text != "" && soyadTextBox.Text != "" && numaraTextBox.Text != "" && gradeComboBox.SelectedItem != null)
            {
                studentManager.name = adTextBox.Text;
                studentManager.surname = soyadTextBox.Text;
                studentManager.number = numaraTextBox.Text;
                studentManager.grade = gradeComboBox.SelectedItem.ToString();
            }
            else
            {
                MaterialMessageBox.Show("Lütfen bilgilerinizi eksiksiz girin.");
            }
        }

        public void downloadExam()
        {
            downloadConfig();
            readConfig();
            DownloadManager downloadManager = new DownloadManager();
            Console.WriteLine("Sınav indiriliyor.");
            examManager.downloadLocation = examDownloadLocation;
            examManager.downloadLink = items[4];
            examManager.examCreators = items[2];
            examManager.examTime = int.Parse(items[3]);
            downloadManager.downloadFile(examManager.downloadLink, examManager.downloadLocation);
            Console.WriteLine("Sınav indirilmesi tamamlandı.");
        }

        public void readConfig()
        {
            dataManager.configParse();
            for (int i = 0; i < dataManager.configParse().Length; i++)
            {
                items[i] = dataManager.configParse()[i];
            }
        }

        public void downloadConfig()
        {
            try
            {
                DownloadManager downloadManager = new DownloadManager();
                downloadManager.downloadFile(DataManager.configLink, dataManager.configLocation);
            }
            catch
            {
                MaterialMessageBox.Show("Config Dosyası İndirilirken Bir Hata Oluştu. Yöneticiye Bildirin.");
                System.Environment.Exit(0);
            }
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
