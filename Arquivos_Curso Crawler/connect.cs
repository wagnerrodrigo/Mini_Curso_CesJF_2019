using HtmlAgilityPack;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.NetworkInformation;


namespace CrawlerConsultaRAB{
    public class Connect{
        public HtmlDocument RequestGet(Uri url){
            HttpWebRequest webRequest = (HttpWebRequest) webRequest.Create(url);
            webRequest.Method = "GET";
            webRequest.AllowAutoRedirect = false;

            HttpWebResponse webResponse = (HttpWebRequest) webRequest.GetResponse();

            string html = new StreamReader(webResponse.GetResponseStream(), Encoding.UTF7).ReadToEnd();

            //HtmlDocument htmlDoc = 
        }
    }
}