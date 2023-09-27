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
        
        //attributes - field
        private int no1;
        private int no2;
        int answ;

        //Created by highliting int no1 and 2, then right click, 
        //then Quick actions...
        //then select Encapsulate fields (and use property)
        public int No1 { get => no1; set => no1 = value; }
        public int No2 { get => no2; set => no2 = value; }

        //these get and set have done manually
        //public int No1   // property
        //{
        //    get { return no1; }   // get method
        //    set { no1 = value; }  // set method
        //}

        //public int No2   // property
        //{
        //    get { return no2; }   // get method
        //    set { no2 = value; }  // set method
        //}
        public void Add()
        {
            answ = No1 + No2;
        }

        public void Display()
        {
            Console.WriteLine("The answer is: " + answ);
            Console.ReadLine();
        }
    }
}
