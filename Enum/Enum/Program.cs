using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        enum Level
        {
            Low,
            Medium,
            High
        }
        static void Main(string[] args)
        {
            int age = 10;
            String student1Name = "Ste";
            Level student1level = Level.Low;

            String student2Name = "Mark";
            Level student2level = Level.Medium;

            Level myVar = Level.Medium;

            Console.WriteLine(myVar);
            Console.WriteLine(age);
            Console.WriteLine(student1Name);
            Console.WriteLine(student2Name);

            Console.ReadLine();

            if(student1level == Level.Low)
            {
                //perform low level student gradings
            }
            else if(student1level == Level.Medium)
            {
                //perform medium level student gradings
            }
        }
    }
}
