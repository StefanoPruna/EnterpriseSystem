using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Inheritance
{
    internal class Manager : Employee
    {
        private double vehicleAllowance;

        public double VehicleAllowance { get => vehicleAllowance; set => vehicleAllowance = value; }

        public void Display()
        {
            Console.WriteLine("Manager No = " + EmpNo + ", Name = " + EmpName + ", Age = " + EmpAge);
        }
        public void DisplayVehicleAllowance()
        {
            Console.WriteLine("Manager Vehicle allowance = " + vehicleAllowance);
        }
    }
}
