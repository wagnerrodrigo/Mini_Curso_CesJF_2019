using HtmlAgilityPack;
using System;

namespace CrawlerConsultaRAB{
    public class Utils{
        public HtmlDocument ParseToHtmlDocument(String html){
            ParseToHtmlDocument htmlDoc = new ParseToHtmlDocument();
            htmlDoc.LoadHtml(html);

            return htmlDoc;
        }
        public Uri SelectQueryType(int tipo, string chave){
            Uri url = new Uri("https://sistemas.anas.gov.br/aeronaves/cons_rab_novo.asp");
            switch(tipo){
                case 1:
                url = new Uri(String.Format("https://sistemas.anac.gov.br/aeronaves/cons_rab_novo.asp?textMarca={0}"),chave);
                break;
            }
        }
    }
}