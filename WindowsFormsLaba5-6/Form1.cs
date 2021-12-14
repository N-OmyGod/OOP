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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }
         
        //если нажата кнопка добавить фильм
        private void addFilm_Click(object sender, EventArgs e)
        {  
            var addForm = new AddCinemaForm();// создаем новую форму для добавления фильма
            this.Visible = false;// закрываем текущую
            addForm.Show(); 
        }

        //если нажата кнопка искать фильм
        private void searchFilm_Click(object sender, EventArgs e)
        {
            var searchForm2 = new SearchFilmForm();//
            this.Visible = false;
            searchForm2.Show();
        }


        //если нажата кнопка искать студента
        private void searchStudent_Click(object sender, EventArgs e)
        {

            var searchForm = new SearchStudentForm();//создаем новую форму для поиска
            this.Visible = false;
            searchForm.Show();
        }

        //если нажата кнопка добавить студента
        private void addStudent_Click(object sender, EventArgs e)
        {
            var addForm2 = new AddStudentForm();// создаем новую форму для добавления
            this.Visible = false;
            addForm2.Show();
        }


        //если нажата кнопка завершить работу
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); //закончить работу программы

        }
    }
}
