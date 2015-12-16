using System;
using System.Collections.Generic;
using System.IO;

namespace pharmacy1
{
    class Collectionwrapper
    {
        //Begin Attributes:
        string filepath = "MyStock.txt"; //Default value in case you forgot to specify one, Feel free to modify.

        //End attributes;
        //Begin Properties:
        public string Filepath
        {
            get { return this.filepath; }
            set { this.filepath = value; }

        }



        //Begin Methods:

        public Collectionwrapper()
        {
            //Defualt Constructor, If you need to manipulate values use the properties above ^^
        }



        public void WriteToFile(Medicine newmed)
        {
            string StockString = newmed.Name + "," + newmed.Desc + "," + newmed.Price + "," + newmed.Quantity + "\r\n";
            //Modify the path here if you're planning on making the user choose the path to save. AND DON'T FORGET THE @
            File.AppendAllText(@filepath, StockString);

        }
        int i = 0;
        public List<Medicine> ReadFile()
        {

            List<Medicine> listfinal = new List<Medicine>();
            List<object> templist = new List<object>();
             

            foreach (var line in File.ReadLines(this.filepath))
            {
            
                foreach (var L in line.Split(','))
                {
                    
                    templist.Add(L);
                }
               
                listfinal.Add(new Medicine(templist[0].ToString(),templist[1].ToString(),int.Parse(templist[3].ToString()),double.Parse(templist[3].ToString())));
                if (i==0)
                {
                    i++;
                    report.totalMedicine += int.Parse(templist[3].ToString());    
                }
                     
                
                
               
                templist.Clear();
            }//end foreach

            return listfinal;

        }


    }
}