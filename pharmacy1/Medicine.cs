using System;
using System.Collections.Generic;
using System.IO;

namespace pharmacy1
{
    class Medicine : Collectionwrapper
    {
        //Begin instant variables.
        //public  List<Medicine> medList = new List<Medicine>();
        string name, desc;
        int quantity;
        double price;
        //end instant variables;

        //begin properties.
      
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public string Desc
        {
            set { }
            get { return this.desc; }
        }
        public double Price
        {
            get { return this.price; }
            set
            {
                if (value > 0.0)
                {
                    this.price = value;
                }
            }
        }



        public int Quantity
        {
            get { return this.quantity; }
            set
            {
                if (value > 0)
                {
                    this.quantity = value;
                }
            }
        }
        //End properties.

        //Begin methods.
        public Medicine(string newname, string newdesc, int newquan, double newprice)
        {
            this.name = newname;
            this.desc = newdesc;
            this.quantity = newquan;
            this.price = newprice;
        }

        public Medicine()
        {
            //Default Constructor.
        }
        public Medicine(string name, int quant, double price)
        {
            this.name = name;
            quantity = quant;
            this.price = price;
        }
    }
}
        /**

        public void Delete_record()
        {
            foreach (var Lines in File.ReadLines("filepath"))
            {
                if (Lines.Contains(this.name))
                {
                    continue;
                }
                File.AppendAllText("MyStock2.txt", Lines);
            }
            File.Replace("MyStock2.txt", "filepath", "Backup.txt");

        }



        public void Modify_record(string Field, object Value)
        {

            this.Delete_record();
            switch (Field)
            {
                case "Name":
                    this.name = (string)Value;
                    break;
                case "Desc":
                    this.desc = (string)Value;
                    break;
                case "Price":
                    this.price = (double)Value;
                    break;
                case "quantity":
                    this.quantity = (int)Value;
                    break;
                default:
                    Console.WriteLine("[-]Error, Wrong Field name or invalid data type value.");
                    break;
            }
            this.write_to_file();






        }


    }
    //End methods;
          
    //End class;
}**/
