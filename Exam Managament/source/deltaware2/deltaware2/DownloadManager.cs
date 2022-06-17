using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace deltaware2
{
    public class DownloadManager
    {
        public void downloadFile(string url, string pathToSaveFile)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using (WebDownload client = new WebDownload())
            {
                client.Headers["User-Agent"] = "User-Agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36";
                Console.WriteLine(url, pathToSaveFile);
                client.DownloadFile(new Uri(url), pathToSaveFile);
            }
        }
    }
    public class WebDownload : WebClient
    {
        protected override WebRequest GetWebRequest(Uri address)
        {
            HttpWebRequest request = (HttpWebRequest)base.GetWebRequest(address);
            if (request != null)
            {
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            }
            return request;
        }
    }
}
