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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Page1 page = new Page1();
             
            if(textBox1.Text == "admin" && textBox2.Text == "admin"){
               
            page.Show();
               
            this.Hide();}
            else
            {
                MessageBox.Show("invalid Username or Password","Error");
            }
            
            

            
        }

        
    }
}
