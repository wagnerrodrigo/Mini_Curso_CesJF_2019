using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using CrawlerConsultaRAB.Registro;
using CrawlerConsultaRAB.Utils;

namespace CrawlerConsultaRAB{

private Utils _utils = new Utils();
    public class Catcher{
        public lista<Registro> GetData(HtmlDocument html){
            HtmlNodeCollection nodesData = html.documentNode.SelectNodes("//div[contains(@class, 'retorno-pesquisa')]/table//tbody/tr");
             Registro newRegistro = new Registro();
            foreach(htmlNode node in nodesData){

                HtmlDocument nodeHtmlDoc = _utils.ParseToHtmlDocument(node);
                
                String indice = nodeHtmlDoc.documentNode.SelectSingleNode("th/text()");
                string texto = string.Empty;
                if(indice.Contains("Motivo(s)")){
                    var motivos = nodeHtmlDoc.DocumentNode.SelectNodes("td/br");

                    if(motivos != null){
                        foreach(var txt in motivos){
                            newRegistro.Motivo.Add(txt.InnerText);
                        }
                    }
                    else{
                        try{
                            texto = nodeHtmlDoc.DocumentNode.SelectSingleNode("td/text()").OuterHtml;
                        }
                        catch{
                            texto = string.Empty;
                            // texto = "";
                        }
                        newRegistro.Texto = texto.Trim();

                    }
                }
                listaRegistro.add(newRegistro);
            }
            return listaRegistro;
        }
    }
}