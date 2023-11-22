using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculatorClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReferenceCalculator.WebServiceCalculatorSoapClient client = new ServiceReferenceCalculator.WebServiceCalculatorSoapClient();
            string number1 = textBox1.Text;
            string number2 = textBox2.Text;
            int n1 = Convert.ToInt32(number1);
            int n2 = Convert.ToInt32(number2);
            int answer = client.Add(n1, n2);
            textBox3.Text = Convert.ToString(answer);
        }
    }
}
