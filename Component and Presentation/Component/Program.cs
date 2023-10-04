using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryCalculator;

namespace Component
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Calculator calculator = new Calculator();
            calculator.No1 = 30;
            calculator.No2 = 30;
            calculator.Add();
            calculator.Display();
        }
    }
}
