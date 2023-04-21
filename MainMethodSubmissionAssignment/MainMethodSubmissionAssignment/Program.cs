using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace ClassesAndObjectsAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciate the calcaulate class
            Calculate number = new Calculate();
            string numberEntered;
            
            //Get User Input            
            Console.Write("Enter a number: ");
            numberEntered =Console.ReadLine();

            //Call each method and pass the input. Convert the input to int,decimal and string for each of the methods
            int answer1 = number.addFive(Convert.ToInt32(numberEntered));               
            float answer2 = number.addFive(Convert.ToDecimal(numberEntered));
            string answer3 = number.modular(numberEntered);


            //Display the returned integer to the screen
            Console.WriteLine("Your number plus 5 is: " + answer1);
            Console.WriteLine("Your number times 5: " + answer2);
            Console.WriteLine("The remainer of your number p divied by your number is: " + answer3);

            Console.ReadKey();
        }

    }
}