using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Controller;
using Model;

namespace View
{
    public partial class FormDisplayBooks : Form
    {
        public FormDisplayBooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
                //Connect to the BookController Class
                BookController bookController = new BookController();
                List<Books> books = bookController.GetAllBooks();

                //display the data
                dataGridView1.DataSource = books;            
        }     

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Move to Users table
            FormDisplayUsers displayUsers = new FormDisplayUsers();
            displayUsers.Show();
        }
    }
}
