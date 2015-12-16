using System;
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
    public partial class Billss : Form
    {
        public Billss()
        {
            InitializeComponent();
        }

        private void Customerna_TextChanged(object sender, EventArgs e)
        {
            string Name = Customerna.Text;
        }

        private void Billname_TextChanged(object sender, EventArgs e)
        {
            string billname = Billname.Text;
        }

        private void Billquan_TextChanged(object sender, EventArgs e)
        {
            int billquan = int.Parse(Billquan.Text);
        }

        //private void BillPric_TextChanged(object sender, EventArgs e)
        //{
        //    double billpric = double.Parse(BillPric.Text);
        //}
        private void AddMetbill_Click(object sender, EventArgs e)
        {
            try
            {
                    customer cust = new customer(Name);
                    bool res = User.ob.sellMed(Billname.Text, int.Parse(Billquan.Text));
                
                if(res==true)
                    MessageBox.Show("Medicine added");
                else
                {
                    MessageBox.Show("error: amount of medicine demanded exceeds amount of medicine in inventory.", "error");
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show("Error" + ee.Message, "Error");
                Billname.Clear();
                Billquan.Clear();
            }
            
        }

        private void Bkkk_Click(object sender, EventArgs e)
        {
            Page1 n = new Page1();
            n.Show();
            this.Hide();
        }

        private void Preparemed_Click(object sender, EventArgs e)
        {
            customer cust = new customer(Customerna.Text);
            string result=User.ob.getBill(cust);
            
            MessageBox.Show(result, "Bill");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        

        
    }
}
