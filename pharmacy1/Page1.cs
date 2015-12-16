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
    public partial class Page1 : Form
    {
        public Page1()
        {
            InitializeComponent();
        }



        Collectionwrapper cwp = new Collectionwrapper();

        private void button4_Click_1(object sender, EventArgs e)
        {
            Billss bil = new Billss();
            bil.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medicinne med = new Medicinne();
            med.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ABOUT ab = new ABOUT();
            ab.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cwp.ReadFile();
            MessageBox.Show(User.ob.getReport(),"Report");
            
            
        }
         
        
    }
}
