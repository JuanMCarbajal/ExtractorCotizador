﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExtractorCotizaciones
{
    class Program
    {

        static void Main(string[] args)
        {

            //Extraer información del XML
            List<string> Links = GetCollectionLinks();

            Console.ReadLine();
            /*
            //var request = (HttpWebRequest)WebRequest.Create("https://www.bcra.gob.ar/PublicacionesEstadisticas/Cotizaciones_por_fecha_2.asp");
            //string link = "http://www.bna.com.ar/Cotizador/HistoricoPrincipales?id=billetes&fecha=23%2F4%2F2019&filtroEuro=1&filtroDolar=1";//"http://www.bna.com.ar/Cotizador/MonedasHistorico";
            var request = (HttpWebRequest)WebRequest.Create(link);

            request.Method = "GET";

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            link = "http://www.bna.com.ar/Cotizador/MonedasHistorico";

            request = (HttpWebRequest)WebRequest.Create(link);

            request.Method = "GET";

            response = (HttpWebResponse)request.GetResponse();

            responseString = responseString + new StreamReader(response.GetResponseStream()).ReadToEnd();

            //Console.WriteLine(responseString.Substring(responseString.IndexOf("<div class=\"contenido\">") + 2, responseString.IndexOf("<footer") + 2 - responseString.IndexOf("<div class=\"contenido\">") + 2));
            Console.WriteLine(responseString);
            Console.Read();
            */
        }

        private static List<string> GetCollectionLinks()
        {
            XDocument X = XDocument.Load("D:\\Cotizaciones\\ExtractorCotizaciones\\ExtractorCotizaciones\\bin\\Debug\\LinkCotizaciones.xml");

            var links = X.Element("links").Elements("link");

            var retorno = new List<string>();

            foreach (XElement link in links)
            {
                retorno.Add(link.ToString());
            }

            return retorno;

             ;
        }
    }
}