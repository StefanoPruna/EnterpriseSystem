using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibraryCalculator;
//I have also to ADD the ClassLibraryCalculator as REFERENCE - right click on the ClassLibraryController,
//ADD, REFERENCE

namespace ClassLibraryController
{
    //This is the Controller logic, contains control logic

    //Change from internal (as default) to public class
    public class CalculatorController
    {
        public int Add(int no1, int no2)
        {
            //connecting to the Backend Logic
            Calculator calculator = new Calculator();

            calculator.No1 = no1;
            calculator.No2 = no2;

            //add the two int numbers
            int answ = calculator.Add();

            return answ;
        }
        public int Divide(int no1, int no2)
        {
            //connecting to the Backend Logic
            Calculator calculator = new Calculator();

            calculator.No1 = no1;
            calculator.No2 = no2;

            //add the two int numbers
            int answ = calculator.Divide();

            return answ;
        }
        public int Minus(int no1, int no2)
        {
            //connecting to the Backend Logic
            Calculator calculator = new Calculator();

            calculator.No1 = no1;
            calculator.No2 = no2;

            //add the two int numbers
            int answ = calculator.Minus();

            return answ;
        }
        public int Multiply(int no1, int no2)
        {
            //connecting to the Backend Logic
            Calculator calculator = new Calculator();

            calculator.No1 = no1;
            calculator.No2 = no2;

            //add the two int numbers
            int answ = calculator.Multiply();

            return answ;
        }
    }
}
