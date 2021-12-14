using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLaba5_6
{
    public partial class AddCinemaForm : Form
    {
        Cinema a = new Cinema();
        public AddCinemaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text;
            string nums = textBox2.Text;
            string nz = textBox3.Text;
            string price = textBox4.Text;
            string begs = textBox5.Text;
            int nr = Convert.ToInt32(nums);
            int nn = Convert.ToInt32(nz);
            int p = Convert.ToInt32(price);
            a.add(n, nr,nn,p,begs);
            this.Visible = false;
            var form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
