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
    public partial class SearchStudentForm : Form
    {
        Hostel b = new Hostel();
        public SearchStudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string group = textBox1.Text;
            string l_y = textBox2.Text;

            int l_y1 = Convert.ToInt32(l_y);
            var c = b.search(group, l_y1);
            foreach (string s in c)
            {

                listBox1.Items.Add(s);
            }
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var form1 = new Form1();
            form1.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
