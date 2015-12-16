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
    public partial class DeletMedicine : Form
    {
        
        public DeletMedicine()
        {
            InitializeComponent();
        }

        private void Backk_Click(object sender, EventArgs e)
        {
            Medicinne l = new Medicinne();
            l.Show();
            this.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        
    {
        
        if (User.ob.SearchList(seachdelet.Text).Name == seachdelet.Text)
                    MessageBox.Show(seachdelet.Text + "   Found","Found");
            else MessageBox.Show(seachdelet.Text+"   Not Found", "Error");
           
            seachdelet.Clear();
           

            
        }

        private void Delet_Click(object sender, EventArgs e)
        {
            
            try
            {
                User.ob.deleteMed(seachdelet.Text);
                MessageBox.Show("your Medicince has been Deleted", "Error");
            }
            catch (Exception eza)
            {

                MessageBox.Show("your Medicince has been Deleted"+eza.Message);
            }
            seachdelet.Clear();
        }

       
    }
}
