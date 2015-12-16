using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pharmacy1
{

     static class Bill
    {
        private static double total;
        //public DateTime date;
        public static double Total
        {
            get { return total; }
            set { total = value; }
        }
         
        public static string returnBill(List<Medicine> med, customer c)
        {

            string result = "Bill:\nCustomer Name:\t" + c.Name + "\nDate: " + DateTime.Now/*new line to Display Date*/+ "\nMedicine\tQuantity\tPrice per unit\tTotal price\n";
            foreach (var x in med)
            {
                result += x.Name + "\t" + x.Quantity + "\t" + x.Price + "\t\t" + (x.Quantity * x.Price) + "\n";
                Total += (x.Quantity * x.Price);
            }
            result += "Total:\t" + Total;
            Total = 0; //new Line
            return result;
        }

    }
}
