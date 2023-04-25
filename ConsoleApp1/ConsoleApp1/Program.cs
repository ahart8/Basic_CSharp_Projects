using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the Employee class
            Employee person = new Employee();
            //Initialize the first name 
            person.FirstName = "Sample";
            //Initialize the last name
            person.LastName = " Student";
            //Call say name from the Employee object
            person.SayName();


        }
    }
}
