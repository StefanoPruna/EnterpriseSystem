using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Calculator
    {
        //we need to create the vars as public because the default access modifier of class is internal
        //Internal access specifier hides its member variables and methods from other classes and objects
        public int no1;
        public int no2;
        int answ;

        public void Add()
        {
            answ = no1 + no2;
        }

        public void Display()
        {
            Console.WriteLine("The answer is: " + answ);
            Console.ReadLine();
        }
    }
}
