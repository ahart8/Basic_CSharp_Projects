using System;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");

            Console.Write("Please enter the package weight: ");
            //double weight=Convert.ToDouble(Console.ReadLine());   -Why is the converted value different that what is entered. For example 50 writes back out as 53

            string enteredWeight = Console.ReadLine();
            double weight = Convert.ToDouble(enteredWeight);

            //Check the weight if it is greater than 100 dispay messsage for too heavy. Then exit the program
            //How do I check for null here. If you hit the enter key you get an error
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadKey();
                System.Environment.Exit(0);
            }

            //Get the width
            Console.Write("Please enter the package width: ");
            double width = Convert.ToDouble(Console.ReadLine());
           
            //Get the height
            Console.Write("Please enter the package height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            //Get the length
            Console.Write("Please enter the package length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            //Add w*h*l check to see if it greater than 50 if it is display message else display quote
            double dimensions = width + height + length;
            if (dimensions > 50)
            {
                Console.Write("Package too big to be shipped via Package Express.");
                Console.ReadKey();
                System.Environment.Exit(0);

            }
             else if (dimensions <= 50)
            {
                //If the total dimensions is less than 50, multiply the three dimensions (w,h,l) together and multiple the product by the weight then divde by 100
                double quote = (width * height * length) * weight / 100;
                Console.WriteLine("Your estimated total for shipping this package is: " + quote);
                Console.ReadKey();
                System.Environment.Exit(0);
            }
        }
    }
}

            
