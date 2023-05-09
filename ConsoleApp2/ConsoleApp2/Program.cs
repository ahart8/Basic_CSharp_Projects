using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validAnswer = false;
            int age = 0;

            while (!validAnswer)
            {
                Console.Write("Please enter your age: ");
                //Takes a string and has an out parameter sends it back over to the bank
                validAnswer = int.TryParse(Console.ReadLine(), out age);
                if (!validAnswer) Console.Write("Please enter digits only. No decimals");

            }
        }
    }
}
