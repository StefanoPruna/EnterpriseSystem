using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCalculator
{
    //Backend Logic 
    //Changed from Internal (default) to Public class
    public class Calculator
    {
        private int no1;
        private int no2;
        private int answ;

        public int No1 { get => no1; set => no1 = value; }
        public int No2 { get => no2; set => no2 = value; }
        public int Answ { get => answ; set => answ = value; }

        public int Add()
        {
            Answ = No1 + No2;
            return Answ;
        }
        public int Minus()
        {
            Answ = No1 - No2;
            return Answ;
        }

        public int Divide()
        {
            Answ = No1 / No2;
            return Answ;
        }

        public int Multiply()
        {
            Answ = No1 * No2;
            return Answ;
        }

        public void Display()
        {
            Console.WriteLine("The answer is " + Answ);
            Console.ReadLine();
        }
    }
}
