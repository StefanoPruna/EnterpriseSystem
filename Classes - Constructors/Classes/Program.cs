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
            // Using the constructor in the Class 
            //I can call(invoke) a constructor more than once       
            Calculator calculator = new Calculator(100, 39);

            //but with the 3 way, it'll work now
            calculator.SetData(490, 30);
            
            //calculator.no1 = 10;
            //calculator.no2 = 20;

            calculator.Add();
            calculator.Display();
        }
    }
}
