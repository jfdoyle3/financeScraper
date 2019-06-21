using System;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;
using System.IO;
using System.Linq;
using System.Data;


namespace financeScraper
{
    public class FromFile : Export
    {
        public List<HtmlNode> ReadFile()
        {
            string stocks = File.ReadAllText(@"C:\website\Stocks.htm");
            HtmlDocument htmlFile = new HtmlDocument();

            htmlFile.LoadHtml(stocks);

            //HtmlNode classList = htmlDoc.DocumentNode.SelectSingleNode("//tr");
            //Console.WriteLine(classList.InnerText);


            List<HtmlNode> classList = htmlFile.DocumentNode.SelectNodes("//td").ToList();


            
            //String[,] table = new String[12, 12];
            //int count = 0;
            //do
            //{
            //    for (var j = 0; j < 12; j++)
            //    {
            //        //Console.Write("{0}", classList[j].InnerText.ToString());
            //        Console.WriteLine(classList[j].InnerText);

            //    }
            //    classList.RemoveRange(count, count + 11);

                
                
            //}
            //while (count < 4);
            
            
           
            return classList;
        }
    }
}
