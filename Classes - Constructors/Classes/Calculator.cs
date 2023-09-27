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
        //attributes
        private int no1;
        private int no2;
        int answ;

        public int No1 { get => no1; set => no1 = value; }
        public int No2 { get => no2; set => no2 = value; }

        //if we keep the vars private:

        //1st way: creating the constructor
        //public Calculator(int x, int y) 
        //{
        //    no1 = x;
        //    no2 = y;
        //}

        //2nd way
        public Calculator(int no1, int no2)
        {
            //current instance
            this.No1 = no1;
            this.No2 = no2;
        }

        //3rd way which needs the 2nd way too
        public void SetData(int no1, int no2)
        {
            this.No1 = no1;
            this.No2 = no2;
        }

        public void Add()
        {
            answ = No1 + No2;
        }

        public void Display()
        {
            if (answ > 500)            
                Console.WriteLine("sorry, but the number is too big");                    

            Console.WriteLine("The answer is: " + answ);
            Console.ReadLine();
        }
    }
}
