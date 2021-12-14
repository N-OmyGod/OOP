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
         

        private void addFilm_Click(object sender, EventArgs e)
        {
           
            var addForm = new AddCinemaForm();
            this.Visible = false;
            addForm.Show();
        }

        private void searchStudent_Click(object sender, EventArgs e)
        {

            var searchForm = new SearchStudentForm();
            this.Visible = false;
            searchForm.Show();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            var addForm2 = new AddStudentForm();
            this.Visible = false;
            addForm2.Show();
        }

        private void searchFilm_Click(object sender, EventArgs e)
        {
            var searchForm2 = new SearchFilmForm();
            this.Visible = false;
         
            searchForm2.Show();
        }
    }
}
