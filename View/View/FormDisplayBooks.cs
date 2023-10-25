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
using Model.DataSetBookTableAdapters;
using static Model.DataSetBook;

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
            BookController bookController1 = new BookController();
            BookController bookController = bookController1;       

            List<Books> books = bookController.GetAllBooks();
            //display the data
            dataGridView1.DataSource = books;            
        }     

        private void button2_Click(object sender, EventArgs e)
        {
            string searchBook = searchTextBox.Text;
            string publishedYear = yearTextBox.Text;            

            BookController bookController = new BookController();

            if (searchBook != "" &&  publishedYear != "")
            {
                int publishYear = Convert.ToInt32(publishedYear);

                List<Books> searchedBook = bookController.SearchBook(searchBook, publishYear);

                //List<Books> allBooks = bookController.GetAllBooks();

                //List<Books> name = bookController.SearchBook(searchBook, publishYear);

                //for (int i = 0; i < allBooks.Count; i++)
                //{                    
                //    if (allBooks.Contains(name))
                //    {
                //        List<Books> searchedBook = bookController.SearchBook(searchBook, publishYear);
                //        dataGridView1.DataSource = searchedBook;
                //    }
                //}


                if (searchBook.StartsWith("p") || publishedYear.Contains("201"))
                {
                    
                    dataGridView1.DataSource = searchedBook;
                }
            }
                   
            else
            {
                if (MessageBox.Show("Your input is incorrect", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {                    
                    FormDisplayBooks book = new FormDisplayBooks();
                    book.Show();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchBook = searchTextBox.Text;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void yearTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
