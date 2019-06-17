using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Selenium;

namespace financeScraper
{
    public class NodetoString : Export
    {
        public dynamic StringNode(List<HtmlNode> stockTable)
        {
            List<String> stockHtml = new List<string>();
            List<String> stockText = new List<string>();

            foreach (HtmlNode node in stockTable)
            {
                stockHtml.Add(node.InnerHtml);
                stockText.Add(node.InnerText);
            }

            string html = String.Join("", stockHtml);
            string text = String.Join("", stockText);

            return html;
        }

        public static void NodesToTable(List<HtmlNode> stockList)
        {
            DataTable tempTable = new DataTable();
            string[] fields =new string [] { "Symbol","LastPrice","Change","ChgPc","Currency","MarketTime","Volume","Shares","AvgVol3m","DayRange","Wk52Range","DayChart","MarketCap"};
            //Console.WriteLine("f:{0} | d:{1}", headers.Count, stockList.Count);

            for (int h = 0; h < fields.Length; h++)
            {
                tempTable.Columns.Add(fields[h]);
               // Console.Write("{0} |", fields[h]);
            }
            int rows = 14;
            int cols = 17;
            int count = 0;
            for (int row = 0; row < rows ; row++)
            {
            for (int s = 0; s < cols; s++)
            {
                //Console.Write(stockList[s].InnerText);
                tempTable.Rows.Add(stockList[s].InnerText);
            }
            //    Console.Write("\n");
                count = count + 13;
                stockList.RemoveRange(0, 13);
            }
            foreach (DataRow row in tempTable.Rows)
            {
                Console.WriteLine();
                foreach (Object item in row.ItemArray)
                {
                    Console.Write(item);
                }
            }

          //  return tempTable;
        }
    }
}
