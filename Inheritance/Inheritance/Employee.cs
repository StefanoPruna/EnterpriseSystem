using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Employee
    {
        private int empNo;
        private string empName;
        private double empAge;

        //Created by highliting the 3 attributes, then right click, 
        //then Quick actions...
        //then select Encapsulate fields (and use property)
        public int EmpNo { get => empNo; set => empNo = value; }
        public string EmpName { get => empName; set => empName = value; }
        public double EmpAge { get => empAge; set => empAge = value; }

        public void Display()
        {
            Console.WriteLine("Employee No = " + empNo + ", Name = " + empName + ", Age = " + empAge);
        }
    }
}
