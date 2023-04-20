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
            int numberEntered = 0;

            //Get User Input            
            Console.Write("Enter a number: ");
            numberEntered= Convert.ToInt32(Console.ReadLine());

            //Call each method and pass the input 
            int answer1=number.addFive(numberEntered);
            int answer2 = number.multiplyByTwo(numberEntered);
            int answer3 = number.modular(numberEntered);


            //Display the returned integer to the screen
            Console.WriteLine("Your number plus 5 is: "+ answer1);
            Console.WriteLine("Your number times 2 is: "+ answer2);
            Console.WriteLine("The remainer of 56 divied by your number is: "+answer3);

            Console.ReadKey();
        }
        
    }
}
