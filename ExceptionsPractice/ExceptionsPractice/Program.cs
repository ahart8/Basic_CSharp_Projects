using System;

namespace ExceptionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two.. ");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
       
            }
           catch(FormatException ex)
            {
                Console.WriteLine("Please enter a whole number");
                Console.ReadLine();
                return;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Please dont divide by 0");
            }
           catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
