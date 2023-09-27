using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.EmpNo = 1;
            employee1.EmpName = "Ste";
            employee1.EmpAge = 30;
            employee1.Display();

            Employee employee2 = new Employee();
            employee2.EmpNo = 2;
            employee2.EmpName = "Mark";
            employee2.EmpAge = 35;
            employee2.Display();

            Console.WriteLine(" ");
            Manager manager1 = new Manager();
            manager1.EmpNo = 1; 
            manager1.EmpName = "Anna";
            manager1.EmpAge = 44;
            manager1.VehicleAllowance = 3000;
            manager1.Display();
            manager1.DisplayVehicleAllowance();

            Console.ReadLine();
        }
    }
}
