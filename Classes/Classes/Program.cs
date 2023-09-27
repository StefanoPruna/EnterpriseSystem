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
            
            calculator.no1 = 10;
            calculator.no2 = 20;

            calculator.Add();
            calculator.Display();
        }
    }
}
