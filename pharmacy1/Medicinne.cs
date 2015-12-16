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
    public partial class Medicinne : Form
    {
        public Medicinne()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            addMed add = new addMed();
            add.Show();
            this.Hide();
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            addMed ad = new addMed();
            ad.Show();
            this.Hide();
        }

        private void Bk_Click(object sender, EventArgs e)
        {
            Page1 s = new Page1();
            s.Show();
            this.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
           
            DeletMedicine l = new DeletMedicine();
            l.Show();
            this.Hide();
        }

        private void Delet_Click(object sender, EventArgs e)
        {
            DeletMedicine l = new DeletMedicine();
            l.Show();
            this.Hide();
        }
    }
}
