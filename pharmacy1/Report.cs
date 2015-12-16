using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pharmacy1
{
    static class report
    {
        /* attributes: */
        
        public static int totalMedicine=1; //total number of medicine units in inventory
        public static int quanitySold = 0; //quantity of medicine units sold
        public static double totalmoney =0; //total money earned 
        public static int reportId = 0;
        //public static DateTime date;
        // bill id
        //public  int quantitySold
        //{
        //    get { return quanitySold;}
        //    set { quanitySold = value; }

        //}
        //public double Totalmoney
        //{

        //    get { return totalmoney; }
        //    set { totalmoney = value; }
        //}
        //public int Quantitysold
        //{

        //    get { return quanitySold; }
        //    set { quanitySold = value; }
        //}
        public static string GetReport()
        {
         
            reportId++;
            string result = "report:\n id : " + reportId + "\n" + "Total Medicine: " 
                + totalMedicine + "\nQuantity Sold: " + quanitySold + "\nMedicine Quantity left: " 
                + (totalMedicine - quanitySold) + "\nTotal money:" + totalmoney;
            return result;
            

        }
        
        
    }

}
