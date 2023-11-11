﻿using System;
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
            //BorrowController borrowController = new BorrowController();
            //List<Borrow> borrow = borrowController.BorrowBook();
            dataGridView1.DataSource = users;

            //ComboBox comboBox = new ComboBox();
            //comboBox.Items.Add(borrow.Count.ToString());
            //comboBox.Items.Add(users[1]);            
            //usernameComboBox.DataSource = comboBox;
            
        }

        private void booksButton_Click(object sender, EventArgs e)
        {
            BookController bookController = new BookController();
            
            List<Books> books = bookController.GetAllBooks();
            dataGridView2.DataSource = books;
            //bookNameComboBox.DataSource = books;
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            string insertUser = usernameTextBox.Text;
            string insertBook = bookTextBox.Text;              
            
            UserController userController = new UserController();
            BookController bookController = new BookController();

            BorrowController borrowController = new BorrowController();
            List<Borrow> borrowBook = borrowController.BorrowBook();

            //System.DateTime currentTime = borrowDateTimePicker.Value;
            dataGridView3.DataSource = borrowBook;
            MessageBox.Show("You have borrowed the book");
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            System.DateTime currentTime = borrowDateTimePicker.Value;
            if (reserveDateTimePicker.Value > currentTime)
            {
                BorrowController borrowController = new BorrowController();
                List<Borrow> borrowBook = borrowController.ReserveBook(); 
                borrowBook.Add(new Borrow());
                dataGridView3.DataSource = borrowBook;
                MessageBox.Show("You have reserved the book");
            }
            else
                MessageBox.Show("Sorry, you have not inserted the correct date.");
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            System.DateTime currentTime = borrowDateTimePicker.Value;
            if (returnDateTimePicker.Value > currentTime)
                MessageBox.Show("You have set a correct date to return the book. Penalty fee apply for late return.");
            else
                MessageBox.Show("Sorry, you have not inserted the correct date.");
        }
    }
}
