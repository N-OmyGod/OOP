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
    public partial class AddStudentForm : Form
    {
        Hostel b = new Hostel();
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sn = textBox1.Text;
            string group = textBox2.Text;
            string n = textBox3.Text;
            string l_y = textBox4.Text;
            int nr=Convert.ToInt32(n);
            int l_y1 = Convert.ToInt32(l_y);
            b.add(sn,group,nr,l_y1);
            this.Visible = false;
            var form1 = new Form1();
            form1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Visible = false;
            var form1 = new Form1();
            form1.Show();
        }
    }
}
