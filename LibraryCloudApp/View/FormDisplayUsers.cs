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

        private void addNewButton_Click(object sender, EventArgs e)
        {
            string newUserName = usernameTextBox.Text;
            string newPassword = passwordTextBox.Text;
            string newLevel = levelTextBox.Text;

            UserController userController = new UserController();

            if(newUserName == "" || newPassword == "" || newLevel == "")
            {
                if (MessageBox.Show("You have not insert the correct details", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                { }
            }
            else
            {
                int level = Convert.ToInt32(newLevel);
                int newUser = userController.InsertNewUser(newUserName, newPassword, level);

                if (newUser == -1)
                    MessageBox.Show("Sorry, you have not inserted the correct details");
                else
                    MessageBox.Show("Good, you have inserted a new User.");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string newUserName = usernameTextBox.Text;
            string newPassword = passwordTextBox.Text;
            string newLevel = levelTextBox.Text;
            string originalUser = originalTextBox.Text;

            UserController userController = new UserController();

            if (newUserName == "" || newPassword == "" || newLevel == "" || originalUser == "")
            {
                if (MessageBox.Show("You have not insert the correct details", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                { }
            }
            else
            {
                int level = Convert.ToInt32(newLevel);
                int newUser = userController.UpdateUser(newUserName, newPassword, level, originalUser);

                if (newUser == -1)
                    MessageBox.Show("Sorry, you have not inserted the correct details");
                else
                    MessageBox.Show("Good, you have updated the User.");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string newUserName = usernameTextBox.Text;

            UserController userController = new UserController();

            if (newUserName == "")
            {
                if (MessageBox.Show("You have not insert the correct details", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                { }
            }
            else
            {
                //int level = Convert.ToInt32(newLevel);
                int newUser = userController.DeleteUser(newUserName);

                if (newUser == -1)
                    MessageBox.Show("Sorry, you have not inserted the correct details");
                else
                {
                    if ((MessageBox.Show("Are you sure want to delete it?", "YesNo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes))
                        MessageBox.Show("Good, Delete Succesful!!!");
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            levelTextBox.Clear();
            originalTextBox.Clear();
            dataGridView1.DataSource = "";
        }
    }
}
