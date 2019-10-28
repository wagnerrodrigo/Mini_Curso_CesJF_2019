using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using CrawlerConsultaRAB.Utils;
using CrawlerConsultaRAB.Catcher;
using CrawlerConsultaRAB.Registro;

namespace CrawlerConsultaRAB{
    public class Navigator{
        private Utils _utils = new Utils();
        private Catcher _catcher = new Catcher();
        private Connect _connect = new Connect();
        private List<Registro> listaRegistro = new List<Registro>();

        public List<Registro> NavToQueryPage(string chave){
            Uri url = _utils.SelectQueryType(1,chave);
            HtmlDocument html = _connect.RequestGet(url);
            
            listaRegistro.AddRange(Catcher.GetData(html));
            return listaRegistro;           
        }
    }
}