using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {      
            Calculator calculator = new Calculator();

            calculator.No1 = 10;
            calculator.No2 = 20;

            calculator.Add();
            calculator.Display();

            calculator.No1 = 30;
            calculator.No2 = 50;

            calculator.Add();
            calculator.Display();
        }
    }
}
