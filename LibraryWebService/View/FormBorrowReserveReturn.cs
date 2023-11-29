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
using Model.DataSetUserTableAdapters;
using Model.DataSetBorrowTableAdapters;
using System.Security.Policy;
using Model.DataSetBookTableAdapters;

namespace View
{
    public partial class FormBorrowReserveReturn : Form
    {
        public FormBorrowReserveReturn()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }



        private void loginButton_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void usernameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bookNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Books books = new Books();
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            List<User> users = userController.GetAllUsers();

            foreach (User item in users)
            {
                //ComboBox userComboBox = new ComboBox();
                //string userName = Convert.ToString(item.UserName);
                string userName = item.UserName;
                int uid = item.Uid;
                //userComboBox.Text = item.UserName;

                userComboBox.Items.Add(userName);
                uidComboBox.Items.Add(uid);
                //userComboBox.SelectedIndex = 0;
                //userComboBox.DataSource = item;
            }

            //userComboBox.DataSource = users;
            //dataGridView1.DataSource = users;           
        }

        private void booksButton_Click(object sender, EventArgs e)
        {
            BookController bookController = new BookController();

            List<Books> books = bookController.GetAllBooks();

            foreach (Books book in books)
            {
                string isbnBook = book.Isbn;
                string bookName = book.BookName;
                bookNameComboBox.Items.Add(bookName);
                isbnComboBox.Items.Add(isbnBook);
            }
            //dataGridView2.DataSource = books;
            //bookComboBox.DataSource = books;
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            System.DateTime currentTime = borrowDateTimePicker.Value;
            System.DateTime returnDate = returnDateTimePicker.Value;

            int sUserName = uidComboBox.SelectedIndex;
            string userName = Convert.ToString(sUserName);
            string bookId = isbnComboBox.Text;

            if (userName == "" || bookId == "")
            {
                if (MessageBox.Show("Please insert both a value in BOOK ISBN && UID fields", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {

                }
            }
            else
            {
                if (returnDateTimePicker.Value > currentTime)
                {
                    BorrowController borrowController = new BorrowController();
                    int bookBorrowed = borrowController.BorrowBook(sUserName, bookId, currentTime, returnDate);

                    if (bookBorrowed == -1)
                        MessageBox.Show("Sorry, save unsuccesful");
                    else
                        MessageBox.Show("Good, You have reserved the book!!!");
                }
                else
                    MessageBox.Show("Sorry, You have not inserted the correct return date");
            }
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            System.DateTime currentTime = borrowDateTimePicker.Value;
            System.DateTime reservedDate = reserveDateTimePicker.Value;

            string bookId = isbnComboBox.Text;
            int userUid = uidComboBox.SelectedIndex;
            string userName = Convert.ToString(userUid);

            if (userName == "" || bookId == "")
            {
                if (MessageBox.Show("Please insert both a value in BOOK ISBN && UID fields", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {

                }
            }
            else
            {
                if (reserveDateTimePicker.Value > currentTime)
                {
                    BorrowController borrowController = new BorrowController();
                    //List<Borrow> borrowBook = borrowController.ReservedBook(userId, sBookId, currentTime); 
                    int bookReserved = borrowController.ReservedBook(userUid, bookId, reservedDate);

                    if (bookReserved == -1)
                        MessageBox.Show("Sorry, save unsuccesful");
                    else
                        MessageBox.Show("Good, You have reserved the book!!!");


                    //dataGridView3.DataSource = bookReserved;
                    //borrowBook.Add(new Borrow());
                    //dataGridView3.DataSource = borrowBook;
                    //MessageBox.Show("You have reserved the book");
                }
                else
                    MessageBox.Show("Sorry, you have not inserted the correct date.");
            }            
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            System.DateTime currentTime = borrowDateTimePicker.Value;
            if (returnDateTimePicker.Value > currentTime)
                MessageBox.Show("You have set a correct date to return the book. Penalty fee apply for late return.");
            else
                MessageBox.Show("Sorry, you have not inserted the correct date.");
        }

        private void userComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showBorrowedBooks_Click(object sender, EventArgs e)
        {
            BorrowController borrowController = new BorrowController();
            List<Borrow> borrows = borrowController.BorrowBookList();

            dataGridView3.DataSource = borrows;
        }

        private void showReservedBooks_Click(object sender, EventArgs e)
        {
            BorrowController borrowController = new BorrowController();
            List<Borrow> borrows = borrowController.ShowReservedBook();

            dataGridView3.DataSource = borrows;
        }

        private void FormBorrowReserveReturn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Delete Reserved Button
            //int rid = uidComboBox.SelectedIndex;
            string bookIsbn = isbnComboBox.Text;

            BorrowController controller = new BorrowController();

            if (bookIsbn == "")
            {
                if (MessageBox.Show("You have not insert the correct details", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                { }
            }
            else
            {
                //int remove = Convert.ToInt32(bookIsbn);
                int deleteRow = controller.DeleteReserved(bookIsbn);
                int deleteBorrow = controller.DeleteBorrow(bookIsbn);

                if (deleteRow == -1 || deleteBorrow == -1)
                    MessageBox.Show("Sorry, you cannot delete the default rows");
                else
                {
                    if ((MessageBox.Show("Are you sure want to delete it?", "YesNo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes))
                        MessageBox.Show("Good, Delete Succesful!!!");
                }
            }
        }

        private void returnLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
