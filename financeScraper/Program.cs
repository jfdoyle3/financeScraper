﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Selenium;
using System.Xml;
using Entityframework;

namespace financeScraper
{
    class Program
    {
        static public void Main(string[] arg)
        {

            // Automated Yahoo Login - inherited classes
            //YahooFinance yf = new YahooFinance();
            //List<List<string>> stockTable = yf.Login();

            // From File
            FromFile scrape = new FromFile();
            List<List<string>> yFinance = scrape.ReadFile();

            // new code below here
            //
            //int i = 0;
            //for (int j=0; j<15; j++)
            //Console.Write("{0}, ",yFinance[i][j].ToString());
            //Console.WriteLine(yFinance[1].Count.ToString());


            //  FinanceDB.DataToTable();
            Console.WriteLine();
            Console.WriteLine(yFinance.ToString());

            //NodetoString tableData = new NodetoString();
            //tableData.StringNode(yFinance);
            //string html = tableData.StringNode(yFinance);

            //HtmlDocument htmlDoc = new HtmlDocument();
            //htmlDoc.LoadHtml(html);

            //// // "/th"                        = Table Headers
            //// // "/td[@aria-label='Symbol']"  = Data Columns

            //List<HtmlNode> headers = htmlDoc.DocumentNode
            //                                .SelectNodes("//tr")
            //                                .ToList();
            //string[] headers = { "Symbol" };
            //List<HtmlNode> stockData = htmlDoc.DocumentNode
            //                                  .SelectNodes("//td[@aria-label='"+headers[0]+"']")
            //                                  .ToList();

            //foreach (var item in headers)
            //    Console.WriteLine(item.InnerText);
            // dynamic result=tableData.NodesToTable(stockData);
            // NodetoString.NodesToTable(stockData);
            //scrape.ViewDataTable(result);
            //scrape.ToDatabase(result);

            //  HtmlNode table = htmlDoc.DocumentNode.SelectSingleNode("//table");
            // table.SelectNodes("/tr[1]/td");
            //foreach (var cell in table.SelectNodes("tr/td"))
            //{
            //    string someVariable = cell.InnerText;
            //}


            //ListConverter.ListToItem(stockData);

            // ArrayList aList = new ArrayList(stockData);
            //string[,] row = new string[12,14];


            // aList.CopyTo(row);




            //var node = htmlDoc.DocumentNode.SelectSingleNode("//tr");

            //HtmlNode sibling = node.NextSibling;

            //while (sibling != null)
            //{
            //    if (sibling.NodeType == HtmlNodeType.Element)
            //        Console.Write(sibling.InnerText);

            //    sibling = sibling.NextSibling;
            //}


            //table/tbody/tr[1]/td[1]
            // tr[1]
            //HtmlNode[] stockData = htmlDoc.DocumentNode
            //                               .SelectNodes("//td")
            //                               .ToArray();

            //foreach(HtmlNode items in stockData)
            //  Console.Write("{0}, ",items.InnerText);




            // tbody   Ancestor
            // tr   Parent
            // td   childern and siblngs
            // list of array rows take rows so they can 
            //ArrayList mylist = new ArrayList(5);



            ////foreach(var list in mylist)
            ////   Console.WriteLine(list);


            //Console.WriteLine(mylist.Count);



            //ListConverter cStockData = new ListConverter();
            //cStockData.ListToItem(stockData);
            //scrape.DataBaseTest(textData);
            //int count = 0;
            //for (int q = 0; q < 12; q++)
            //{
            //    for (int a = count; a < count+13; a++)
            //    {
            //        Console.Write("{0},",textData[a]);
            //    }
            //    Console.WriteLine();
            //    count = count + 16;
            //}

        }
        public static void PrintValues(String[] myArr, char mySeparator)
        {
            for (int i = 0; i < myArr.Length; i++)
                Console.Write("{0}{1}", mySeparator, myArr[i]);
            Console.WriteLine();
        }
    }
}

