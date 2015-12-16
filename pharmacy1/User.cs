using System;
using System.Collections.Generic;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy1
{
    class User
    {

        //Attr..
        customer cust1;
        public static User ob = new User(5);
        string id, password;
        Collectionwrapper xx = new Collectionwrapper();

        List<Medicine> medlist;
        public User(int x)
        {
            medlist = xx.ReadFile();
           
        }
        

        
      
        List<Medicine> soldMedList = new List<Medicine>();
        //Props..
        public string Id { get { return id; } set { id = value; } }
        public string Password { get { return password; } set { password = value; } }
        //Ctor
        public User()
        {

        }
        public User(string name, string pw)
        {
            id = name;
            password = pw;
        }
        //end of ctor
        //Medicines list 
        
        //start of methods
        Collectionwrapper CW = new Collectionwrapper();

        public void addMed(string name, string disc, int quan, double price)
        {
            Medicine obj = new Medicine(name, disc, quan, price);
            CW.WriteToFile(obj);
           medlist.Add(obj);
            report.totalMedicine += quan; //new
        }

        public void deleteMed(string med)
        {
            foreach (Medicine i in medlist)
            { 
                if (i.Name == med)
               {
                   if (medlist.Remove(i))
                   {
                    ob.Save();
                    report.totalMedicine -= i.Quantity; //new     
                   }
                   else Console.WriteLine("NOPE");
                
                }
            }
        }

        public bool Check(string med)
        {
            bool check = false;
            foreach (Medicine i in medlist)
            {
                if (i.Name == med)
                {
                    check = true;
                }
                //else
                //    check = false;
            }
            return check;
        }

        public void Modify(string medName, int quant, double price)
        {
            foreach (var i in medlist)
            {
                if (medName == i.Name)
                {
                    if (quant > i.Quantity) report.totalMedicine += (quant - i.Quantity); //new
                    else if(quant < i.Quantity) report.totalMedicine -=(i.Quantity - quant) ; //new
                    i.Quantity = quant;
                    i.Price = price;
                }
            }
            Save();
        
        }
        public Medicine SearchList(string medName)
        {
            //i'll explain later..

            //List<string> objarr = new List<string>();

            Medicine temp_med = new Medicine();
            foreach (var i in medlist)
            {
                if (medName == i.Name)
                {
                    Console.WriteLine('\n' + i.Name + " Found!");
                    
                    temp_med = i;
                  
                } //end if	

            }//end foreach

            return temp_med;
        }
        public bool sellMed(string medName,int quant)
        {
            if (this.Check(medName))
            {
                this.SearchList(medName);
                foreach (var i in medlist)
                {
                    if (medName == i.Name)
                    {
                        if(quant>i.Quantity)
                        {
                            MessageBox.Show("Not enough ammount ");
                            return false;
                        }
                        i.Quantity = i.Quantity - quant;
                        ob.Save(); // updated to save in file
                        Medicine soldMed = new Medicine(medName, quant, i.Price);
                        soldMedList.Add(soldMed);
                        report.totalmoney += (i.Price*quant); //new
                        report.totalMedicine -= quant; //new
                        report.quanitySold += quant;
                    }
                }
            }
            return true;
        }

        public string getReport()
        {
            return report.GetReport();
        }

        public string getBill(customer cust)
        {
            cust1 = cust;
            string bill = Bill.returnBill(soldMedList , cust1);
            soldMedList.Clear();
            return bill;
        }
        // cutomers 
        public customer addCustomer(string name)
        {
           return cust1 = new customer(name);
        }

        public void Save()
        {
            File.Delete("MyStock.txt");
            String StringToWrite="";
            foreach (var element in medlist)
            {

              StringToWrite += element.Name + ',' + element.Desc + ',' + element.Price + ',' + element.Quantity + "\r\n";
              
                
            
            
            }

            File.WriteAllText("MyStock.txt", StringToWrite);
        }

    }

}