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
       
        public SearchFilmForm()
        {
            InitializeComponent();
        }


        // обработка нажатия кнопки назад
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var form1 = new Form1();
            form1.Show();
        }

        //обработка нажатия кнопки поиск
        private void searchButton_Click(object sender, EventArgs e)
        {
            ContainerList a = new ContainerList();// создаем обьект класса 
            a.searchFilm= textBox1.Text;
            a.search();
            textBox2.Text = a.percent.ToString();//выводим процент заполненности в форму


        }


        private void SearchFilmForm_Load(object sender, EventArgs e)
        {

        }
    }
}
