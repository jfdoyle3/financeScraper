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
        public static void DataToTable()
        {
            
                using (FinanceTableData db = new FinanceTableData())
                {
                // Create and save a new FinanceTable

                //string[] stockData = { "AMD", "$1.23", "-0.15", "+1.23", "USD", "4:00pm", "5.5b", "32", "34.65m", "3-5", "4-7", "chart", "100b", "buy/sell" };
                //string[] stockData = { "AMD", "$1.23" };

                string symbol = "Resistance is Futile!!- Oh MY!!!";
                   string place = "Borg Cube";

                for (int i = 0; i < 12; i++)
                {
                    FinanceTable financeTable = new FinanceTable
                    {
                        // ID = DateTime.Now,
                        Symbol = symbol,
                        Place = place,
                        //LastPrice = lastPrice,
                        //Change = change,
                        //ChgPc = chgPc, 
                        //Currency = currency,
                        //MarketTime = martkettime,
                        //Volume = volume,
                        //Shares = shares,
                        //AvgVol3m = avgVol3m,
                        //DayRange = dayRange,
                        //Wk52Range = wk52Range,
                        //DayChart = dayChart,
                        //MarketCap = marketCap                                           
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
        
        public int ID { get; set; }
        public string Symbol { get; set; }
        public string Place { get; set; }

      
    }

   

    public class FinanceTableData : DbContext
    {
        public DbSet<FinanceTable> FinanceTables { get; set; }
       
    }
}



