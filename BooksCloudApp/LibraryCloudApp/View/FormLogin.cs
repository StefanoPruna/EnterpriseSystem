using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sUserName = textBox1.Text;
            string sPassword = textBox2.Text;

            UserController userController = new UserController();
            //userController.ValideLogin(sUserName, sPassword);
            User user = userController.ValideLogin(sUserName, sPassword);

            //int userName = Convert.ToInt32(sUserName);
            //int password = Convert.ToInt32(sPassword);

            if (sUserName == "" || sPassword == "" || user == null)
            {
                if (MessageBox.Show("Your login is incorrect", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                { }
            }
            else if (sUserName == user.UserName && sPassword == user.Password)
            {
                if (MessageBox.Show("Your login is correct", "Run", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (sUserName == "admin" && sPassword == "admin")
                    {
                        FormDisplayUsers formDisplayUsers = new FormDisplayUsers();
                        formDisplayUsers.Show();
                    }
                    else
                    {
                        FormDisplayBooks studentDashboard = new FormDisplayBooks();
                        studentDashboard.Show();
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Your login is incorrect", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                { }
                else if (MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Exit();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
