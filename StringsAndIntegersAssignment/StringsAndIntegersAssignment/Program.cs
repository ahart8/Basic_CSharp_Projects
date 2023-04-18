using System;
using System.Collections.Generic;

namespace StringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
         {
            //Add try catch to handle exceptions
            try
            {
                List<int> listOfNumbers = new List<int> { 22, 36, 38, 46, 122, 56, 82 };
                Console.Write("Enter a number to divide by: ");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                int numberThree = 0;
                foreach (int numberOne in listOfNumbers)
                {
                    numberThree = numberOne / numberTwo;
                    Console.WriteLine(numberOne + "/" + numberTwo + " = " + numberThree);
                }
           
            }
            //Display a message if the user enters 0
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please dont divide by 0");
            }
            //Display a message if the user enters a value other than a number
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number");
            }
            //Display exception message if there is a different type of error other than what is handled above
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                //This was add to show that the program has emerged the try catch block
                Console.WriteLine("You made out of the try catch block");
                Console.ReadLine();
            }
        }
    }
}
