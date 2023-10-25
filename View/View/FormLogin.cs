using Controller;
using Model;
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
            userController.ValideLogin(sUserName, sPassword);
            User user = userController.ValideLogin(sUserName, sPassword);

            //int userName = Convert.ToInt32(sUserName);
            //int password = Convert.ToInt32(sPassword);

            if (sUserName == "user" && sPassword == "user")
            {
                if (MessageBox.Show("Your login is correct", "Run", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    FormDisplayBooks studentDashboard = new FormDisplayBooks();
                    studentDashboard.Show();                    
                }
            }
            else if (sUserName == "admin" && sPassword == "admin")
                {
                if (MessageBox.Show("Your login is correct", "Run", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    FormDisplayUsers formDisplayUsers = new FormDisplayUsers();
                    formDisplayUsers.Show();
                }
            }
            else
            {
                if (MessageBox.Show("Your login is incorrect", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    Application.Restart();
                else if (MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Exit();
            }
        }
    }
}
