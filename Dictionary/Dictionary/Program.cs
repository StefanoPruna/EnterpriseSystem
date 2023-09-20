using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> listOfStudent = new Dictionary<string, string>();

            listOfStudent.Add("student1", "Ste");
            listOfStudent.Add("student2", "Max");
            listOfStudent.Add("student3", "Alex");
            listOfStudent.Add("student4", "Ann");

            Console.WriteLine();

            foreach (KeyValuePair<string, string> kvp in listOfStudent)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }

            Console.ReadLine();
        }
    }
}
