using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace EmployeeAnalyzerApp.Model
{
    class URLLoader : IFileLoader
    {
        public string[] LoadFile(string url)
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            string urlData = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                urlData = reader.ReadToEnd();
            }
            var data = new HashSet<string>(urlData.Split('\n'));
            string[] lines = data.ToArray();

            return lines;
        }
    }
}
