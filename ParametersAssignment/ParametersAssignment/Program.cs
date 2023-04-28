using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace ParametersAssignment
{
    class Program 
    {
        public static void Main(string[] args)
        {
            //instanciate the employee object with type string
            Employee<string> employee = new Employee<string>();
            employee.Thing = new List<string>() { "one", "two", "three", "four" };
            Employee<int> employee1 = new Employee<int>();
            employee1.Thing = new List<int>() { 1, 2, 3, 4 };

            //Create a loop that prints out all of the things to the console
            foreach (string thing in employee.Thing)
            {
                Console.WriteLine(thing);
            }
            foreach (int thing1 in employee1.Thing)
            {
                Console.WriteLine(thing1);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }

   
}
