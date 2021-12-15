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
        
        public AddStudentForm()
        {
            InitializeComponent();
        }
        // обработка нажатия кнопки добавить
        private void addButton_Click(object sender, EventArgs e)
        {
            ContainerDictionary b = new ContainerDictionary();
            //считываем даннные с формы
            string fullName = textBox1.Text;
            string group = textBox2.Text;
            int nroom = Convert.ToInt32(textBox3.Text);
            int last_y = Convert.ToInt32(textBox4.Text);

            //вызываем метод добавления обьекта в cловарь
            b.add(fullName, group, nroom, last_y);
            //после добавления закрываем форму
            this.Visible = false;
            var form1 = new Form1();
            form1.Show();

        }

      

        private void backButton_Click_1(object sender, EventArgs e)
        {

            this.Visible = false;
            var form1 = new Form1();
            form1.Show();
        }
    }
}
