using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Threading;

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
            string response = "";
            try
            {
                response = WebClient.DownloadString(url);
                return response;
            }
            catch (WebException ex)
            {
                Console.WriteLine("RATEEEEE LIMITED");
                WebClient.ResponseHeaders.Keys.Cast<string>().ToList().ForEach(h => Console.WriteLine(h));

                Thread.Sleep(10000);

                return Get(url);
            }
        }
        public string Post(string url, string data)
        {
            string response = "";
            try
            {
                response = WebClient.UploadString(url, "POST", data);
                return response;
            }
            catch (WebException ex)
            {
                Console.WriteLine("RATEEEEE LIMITED");
                WebClient.ResponseHeaders.Keys.Cast<string>().ToList().ForEach(h => Console.WriteLine(h));

                Thread.Sleep(10000);

                return Post(url, data);
            }
        }
        public string Put(string url, string data)
        {
            string response = "";
            try
            {
                response = WebClient.UploadString(url, "PUT", data);
                return response;
            }
            catch (WebException ex)
            {
                Console.WriteLine("RATEEEEE LIMITED");
                WebClient.ResponseHeaders.Keys.Cast<string>().ToList().ForEach(h => Console.WriteLine(h));

                Thread.Sleep(10000);

                return Put(url, data);
            }
        }
    }
}
