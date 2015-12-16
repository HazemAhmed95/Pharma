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
    public partial class addMed : Form
    {
        
        public addMed()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Medicinne m = new Medicinne();
            m.Show();
            this.Hide();
        }

        private void addMed_Load(object sender, EventArgs e)
        {
            
        }

        private void SaveMe_Click(object sender, EventArgs e)
        {
            
           
            try
            {
              User.ob.addMed(addname.Text, addDes.Text, int.Parse(addqu.Text), double.Parse(addpric.Text));
                MessageBox.Show("your Medicine is Added");
                User.ob.Save();
            }

            catch (Exception eee)
            { MessageBox.Show("Error"+eee.Message,"Error"); }
            addname.Clear();
            addpric.Clear();
            addqu.Clear();
            addDes.Clear();
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            //User ob = new User();
            try
            {
                User.ob.Modify(addname.Text, int.Parse(addqu.Text), double.Parse(addpric.Text));
                MessageBox.Show(" The Medcine Is Modfied", "Modfied");
            }
            catch (Exception eeee)
            {

                MessageBox.Show("Error"+eeee.Message,"Error");
            }
            
            addname.Clear();
            addpric.Clear();
            addqu.Clear();
            addDes.Clear();
        }
    }
}
