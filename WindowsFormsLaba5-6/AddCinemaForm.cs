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
        
        public AddCinemaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContainerList a = new ContainerList();
           //считываем даннные с формы
            string name = textBox1.Text;
            int fullCount = Convert.ToInt32(textBox2.Text);
            int count = Convert.ToInt32(textBox3.Text);
            int price = Convert.ToInt32(textBox4.Text);
            string beg = textBox5.Text;
       
            //вызываем метод добавления обьекта в лист
            a.add(name, fullCount, count, price, beg);
            //после добавления закрываем форму
            this.Visible = false;
            var form1 = new Form1();
            form1.Show();
        }

    }
}
