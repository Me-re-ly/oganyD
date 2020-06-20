using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dynago
{
    class Networking
    {      
        public static void DownloadFile(string url, string path) {
            // Make sure the directory I'm downloading the file to exists.
            string dirPath = Path.GetDirectoryName(path);
            if (!Directory.Exists(dirPath)) Directory.CreateDirectory(dirPath);
            using (WebClient web = new WebClient()) {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                    | SecurityProtocolType.Tls11
                    | SecurityProtocolType.Tls12
                    | SecurityProtocolType.Ssl3;
                web.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.97 Safari/537.36");
                web.NullifyProxy();
                web.DownloadFile(url, path);
            }
        }
    }
}
