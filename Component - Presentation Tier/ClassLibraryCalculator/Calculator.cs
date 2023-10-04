using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCalculator
{
    //Changed from Internal (default) to Public class
    public class Calculator
    {
        private int no1;
        private int no2;
        private int answ;

        public int No1 { get => no1; set => no1 = value; }
        public int No2 { get => no2; set => no2 = value; }
        public int Answ { get => answ; set => answ = value; }

        public void Add()
        {
            Answ = No1 + No2;
        }

        public void Display()
        {
            Console.WriteLine("The answer is " + Answ);
            Console.ReadLine();
        }
    }
}
