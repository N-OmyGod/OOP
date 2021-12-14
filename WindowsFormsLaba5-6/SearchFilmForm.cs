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
    public partial class SearchFilmForm : Form
    {
       Cinema a=new Cinema();
        public SearchFilmForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sn = textBox1.Text;
            var c = a.search(sn);
           var b= c.ToString();
            textBox2.Text=b;


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchFilmForm_Load(object sender, EventArgs e)
        {

        }
    }
}
