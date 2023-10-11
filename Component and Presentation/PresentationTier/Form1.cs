using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//I have to ADD the ClassLibraryCalculator as REFERENCE - right click on the PresentationTier, ADD, REFERENCE
using ClassLibraryCalculator;

namespace PresentationTier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitButton(object sender, EventArgs e)
        {
            //Add a message when exit
            if (MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //multiply button
            //get text from the two text boxes
            string s2 = textBox2.Text;
            string s1 = textBox1.Text;

            Calculator calculator = new Calculator();

            //convert the strings into int
            int no2 = Convert.ToInt32(s2);
            int no1 = Convert.ToInt32(s1);

            calculator.No1 = no1;
            calculator.No2 = no2;
            
            //multiply the two int numbers
            int answ = calculator.Multiply();

            //convert the answ from int to string
            string myAnswer = answ.ToString();

            //set the answer into the 3rd text box
            textBox3.Text = myAnswer;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //MINUS button
            //get text from the two text boxes
            string s2 = textBox2.Text;
            string s1 = textBox1.Text;

            Calculator calculator = new Calculator();

            //convert the strings into int
            int no2 = Convert.ToInt32(s2);
            int no1 = Convert.ToInt32(s1);
            
            calculator.No1 = no1;
            calculator.No2 = no2;

            //minus the two int numbers
            int answ = calculator.Minus();

            //convert the answ from int to string
            string myAnswer = answ.ToString();

            //set the answer into the 3rd text box
            textBox3.Text = myAnswer;
        }

        private void button5_Click(object sender, EventArgs e)
        {
                //DIVISION button
            //get text from the two text boxes
            string s2 = textBox2.Text;
            string s1 = textBox1.Text;

            Calculator calculator = new Calculator();

            //convert the strings into int
            int no2 = Convert.ToInt32(s2);
            int no1 = Convert.ToInt32(s1);

            calculator.No1 = no1;
            calculator.No2 = no2;

            //divide the two int numbers
            int answ = calculator.Divide();

            //convert the answ from int to string
            string myAnswer = answ.ToString();

            //set the answer into the 3rd text box
            textBox3.Text = myAnswer;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Clear button
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                //PLUS button
            //get text from the two text boxes
            string s2 = textBox2.Text;
            string s1 = textBox1.Text;

            //connecting to the Backend Logic
            Calculator calculator = new Calculator();
                        
            //convert the strings into int
            int no2 = Convert.ToInt32(s2);
            int no1 = Convert.ToInt32(s1);

            calculator.No1 = no1;
            calculator.No2 = no2;

            //add the two int numbers
            int answ = calculator.Add();

            //Frontend task
            //convert the answ from int to string
            string myAnswer = answ.ToString();

            //set the answer into the 3rd text box
            textBox3.Text = myAnswer;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Save button, the View UI
        }
    }
}
