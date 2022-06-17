using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deltaware2
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                DataManager dataManager = new DataManager();
                if (!dataManager.checkVeriable())
                {
                    dataManager.getConfigInformation();
                }else
                {
                    MaterialSkin.Controls.MaterialMessageBox.Show("Sınava zaten giriş yapıldı. Yönetici öğretmene bildirin.");
                    System.Environment.Exit(1);
                }
            }catch (Exception)
            {
                MessageBox.Show("App Config Hatası");
                System.Environment.Exit(1);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
