using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace Discord4Console.Models
{
    class NetClient
    {
        WebClient WebClient { get; set; }

        public NetClient()
        {
            WebClient = new WebClient();

            AddHeader("user-agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) discord/0.0.301 Chrome/56.0.2924.87 Discord/1.6.15 Safari/537.36");
            AddHeader("content-type", "application/json");
        }

        public void AddHeader(string name, string value)
        {
            WebClient.Headers.Add(name, value);
        }

        public string Get(string url)
        {
            return WebClient.DownloadString(url);
        }
        public string Post(string url, string data)
        {
            return WebClient.UploadString(url, "POST", data);
        }
        public string Put(string url, string data)
        {
            return WebClient.UploadString(url, "PUT", data);
        }
    }
}
