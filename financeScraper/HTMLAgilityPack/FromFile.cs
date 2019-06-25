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
        public List<List<string>> ReadFile()
        {
            string stocks = File.ReadAllText(@"C:\website\Stocks.htm");
            HtmlDocument htmlFile = new HtmlDocument();

            htmlFile.LoadHtml(stocks);

            //HtmlNode classList = htmlDoc.DocumentNode.SelectSingleNode("//tr");
            //Console.WriteLine(classList.InnerText);


            // List<HtmlNode> classList = htmlFile.DocumentNode.SelectNodes("//td").ToList();
            List<List<string>> stockTable =
                                    htmlFile.DocumentNode.SelectSingleNode("//table")
                                                .Descendants("tr")
                                                .Skip(1) //To Skip Table Header Row
                                                .Where(tr => tr.Elements("td").Count() > 1)
                                                .Select(tr => tr.Elements("td").Select(td => td.InnerText.Trim()).ToList())
                                                .ToList();


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

            for (int row = 0; row < stockTable.Count; row++)
            {
                for (int col = 0; col < stockTable[0].Count; col++)
                {
                     if (col%15==0)
                        Console.WriteLine();
                    Console.Write("{0},",stockTable[row][col].ToString());

                }
            }
            

            return stockTable;
        }
    }
}
