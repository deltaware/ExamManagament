using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Tommy;

namespace deltaware2
{
    public class DataManager
    {
        public string appConfigLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "appInformation.toml");
        public string configLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "examInformation.toml");
        public static string configLink { get; set; }
        public string[] configParse()
        {
            string[] items = new string[7];
            using (StreamReader reader = File.OpenText(configLocation))
            {
                TomlTable table = TOML.Parse(reader);
                items[0] = table["schoolName"];
                items[1] = table["examInfo"]["name"];
                items[2] = table["examInfo"]["creators"];
                items[3] = table["examInfo"]["time"];
                items[4] = table["examLinks"]["firstLink"];
                items[5] = table["examLinks"]["secondLink"];
                items[6] = table["examLinks"]["thirdLink"];
            }
            return items;
        }

        public void changeVeriable(bool finished)
        {
            TomlTable toml = new TomlTable
            {
                ["examConfigLink"] = configLink,
                ["examFinished"] = finished.ToString()
            };
            using (StreamWriter writer = File.CreateText(appConfigLocation))
            {
                toml.WriteTo(writer);
                writer.Flush();
            }
        }

        public bool checkVeriable()
        {
            bool finished = true;
            using (StreamReader reader = File.OpenText(appConfigLocation))
            {
                TomlTable table = TOML.Parse(reader);
                finished = bool.Parse(table["examFinished"].ToString().ToLower());
            }
            return finished;
        }

        public void getConfigInformation()
        {
            using (StreamReader reader = File.OpenText(appConfigLocation))
            {
                TomlTable table = TOML.Parse(reader);
                configLink = table["examConfigLink"];
            }
            DownloadManager downloadManager = new DownloadManager();
            downloadManager.downloadFile(configLink, configLocation);
        }
    }
}
