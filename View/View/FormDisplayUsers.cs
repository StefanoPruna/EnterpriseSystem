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
    public partial class FormDisplayUsers : Form
    {
        public FormDisplayUsers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Connect to the UserController Class
            UserController userController = new UserController();
            List<User> users = userController.GetAllUsers();

            //display the data
            dataGridView1.DataSource = users;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Move to Books table
            FormDisplayBooks displayBooks = new FormDisplayBooks();
            displayBooks.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormCategoryMaster formCategory = new FormCategoryMaster();
            formCategory.Show();
        }
    }
}
