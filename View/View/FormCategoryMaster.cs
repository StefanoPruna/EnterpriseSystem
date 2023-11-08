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
    public partial class FormCategoryMaster : Form
    {
        public FormCategoryMaster()
        {
            InitializeComponent();
        }

        private void categoryNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string cidCategory = cidTextBox.Text;
            string categoryName = categoryNameTextBox.Text;
            string newName = updateNameTextBox.Text;
            string newCid = updateCidTextBox.Text;

            CategoryController categoryController = new CategoryController();

            int oldCid = Convert.ToInt32(cidCategory);
            int updatedCid = Convert.ToInt32(newCid);

            int noOfRows = categoryController.UpdateCategory(categoryName, oldCid, newName, updatedCid);

            if (noOfRows == -1)
                MessageBox.Show("Sorry, update unsuccesful");
            else
                MessageBox.Show("Good, Update Succesful!!!");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //string cidCategory = cidTextBox.Text;
            string categoryName = categoryNameTextBox.Text;

            CategoryController categoryController = new CategoryController();

            //int cid = Convert.ToInt32(cidCategory);

            int noOfRows = categoryController.SaveCategory(categoryName);
            
            if(noOfRows == -1)
                MessageBox.Show("Sorry, save unsuccesful");
            else
                MessageBox.Show("Good, Save Succesful!!!");

            //dataGridView1.DataSource = noOfRows;
         }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string cidCategory = cidTextBox.Text;
            string categoryName = categoryNameTextBox.Text;

            CategoryController categoryController = new CategoryController();

            int cid = Convert.ToInt32(cidCategory);

            int noOfRows = categoryController.DeleteCategory(cid);
            //add you have to add both the CID and the name to work
            if (noOfRows == -1)
                MessageBox.Show("Sorry, delete unsuccesful");
            else
                MessageBox.Show("Good, Delete Succesful!!!");
        }

        private void showCategorybutton_Click(object sender, EventArgs e)
        {
            CategoryController categoryController = new CategoryController();
            List<Category> categories = categoryController.ShowCategory();
            
            dataGridView1.DataSource = categories;
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            FormDisplayUsers formDisplayUsers = new FormDisplayUsers();
            formDisplayUsers.Show();
        }

        private void updateCidLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
