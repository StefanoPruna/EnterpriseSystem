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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
            string searchBookName = searchTextBox.Text;
            string publishedYear = yearTextBox.Text;     
            string publisherName = publisherTextBox.Text;

            BookController bookController = new BookController();

            if (searchBookName == "" || publishedYear == "")
            {
                if (MessageBox.Show("Please insert both a value in bookname && publisher && publish year", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                   
                }                               
            }
            else
            {
                int publishYear = Convert.ToInt32(publishedYear);

                List<Books> searchedBooks = bookController.SearchBook(searchBookName, publishYear, publisherName);
                dataGridView1.DataSource = searchedBooks;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Clear button
            searchTextBox.Clear();
            yearTextBox.Clear();
            publisherTextBox.Clear();
            dataGridView1.DataSource = "";
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            FormBorrowReserveReturn borrowBook = new FormBorrowReserveReturn();
            borrowBook.Show();
        }
    }
}
