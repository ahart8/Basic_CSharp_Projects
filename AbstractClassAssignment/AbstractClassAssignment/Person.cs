using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
   abstract class Person
    {
        //Set the properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void SayName()
        {
            //Print out the full name by concatenating first and last name
            string fullName = FirstName + LastName;
            Console.WriteLine("Name: " + fullName);
            Console.ReadLine();

        }
    }
}
