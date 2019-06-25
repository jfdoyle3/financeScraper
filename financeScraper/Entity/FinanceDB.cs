using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entityframework
{
    
     public class FinanceDB
    {
        public static void DataToTable(List<List<String>> stockTable)
        {
            
                using (FinanceTableData db = new FinanceTableData())
                {
                // Create and save a new FinanceTable

                //string[] stockData = { "AMD", "$1.23", "-0.15", "+1.23", "USD", "4:00pm", "5.5b", "32", "34.65m", "3-5", "4-7", "chart", "100b", "buy/sell" };
                //string[] stockData = { "AMD", "$1.23" };

                string symbol = "Resistance is Futile!!- Oh MY!!!";
                string place = "Borg Cube";

                for (int i = 0; i < stockTable.Count; i++)
                {
                    
                    FinanceTable financeTable = new FinanceTable
                    {
                        ID = DateTime.Now,
                        //Symbol = stockTable[x][xx],
                        //LastPrice = stockTable[x][xx],
                        //Change = stockTable[x][xx],
                        //ChgPc = stockTable[x][xx],
                        //Currency = stockTable[x][xx],
                        //MarketTime = stockTable[x][xx],
                        //Volume = stockTable[x][xx],
                        //Shares = stockTable[x][xx],
                        //AvgVol3m = stockTable[x][xx],
                        //DayRange = stockTable[x][xx],
                        //Wk52Range = stockTable[x][xx],
                        //DayChart = stockTable[x][xx],
                        //MarketCap = stockTable[x][xx],
                        //Field1 = stockTable[x][xx],
                        //Field2 = stockTable[x][xx],
                        //Field3 = stockTable[x][xx]
                    };

                    db.FinanceTables.Add(financeTable);
                    db.SaveChanges();
                }
                    // Display all Blogs from the database
                    //IOrderedQueryable query = from b in db.FinanceTables
                    //                          orderby b.Symbol
                    //                          select b;

                    Console.WriteLine("All Data in the database:");
                    //foreach (FinanceTable item in query)
                    //{
                    //    Console.WriteLine(item.Symbol, item.Place);
                    //}

                   
                    
                
                
            }
        }
    }

    public class FinanceTable
    {
        
        public DateTime ID { get; set; }
        public string Symbol { get; set; }
        public string Place { get; set; }
        public string LastPrice { get; set; }
        public string Change { get; set; }
        public string ChgPc { get; set; }
        public string Currency { get; set; }
        public string MarketTime { get; set; }
        public string Volume { get; set; }
        public string Shares { get; set; }
        public string AvgVol3m { get; set; }
        public string DayRange { get; set; }
        public string Wk52Range { get; set; }
        public string DayChart { get; set; }
        public string MarketCap { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }



    }

   

    public class FinanceTableData : DbContext
    {
        public DbSet<FinanceTable> FinanceTables { get; set; }
       
    }
}



