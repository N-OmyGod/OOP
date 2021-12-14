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
        
        public SearchStudentForm()
        {
            InitializeComponent();
        }


        // обработка нажатия кнопки поиск
        private void searchButton_Click(object sender, EventArgs e)
        {
            ContainerDictionary b = new ContainerDictionary();
           b.search_gr = textBox1.Text;//заданная группа
           b.search_y = Convert.ToInt32(textBox2.Text);// заданный год
           b.search(); // поиск
            foreach (string s in b.foundValue) // выводим в текстбокс студентов из листа foundValue 
            {
                Null.Items.Add(s);
            }
           
        }

        // обработка нажатия кнопки назад
        private void backButton_Click(object sender, EventArgs e)
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
