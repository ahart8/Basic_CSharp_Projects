﻿using System;

namespace MethodWithOptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {

            
                Console.WriteLine("Please enter 2 numbers. The first an entry is not required for the second number");
                Console.WriteLine("Enter the first number: ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());

                try
                {
                Console.WriteLine("Enter the second number: ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                //Instanciate the (misspelled) class in the main method
                OptionialParameter optionalParameter = new OptionialParameter();
                optionalParameter.addTwoNumbers(firstNumber, secondNumber);
                              
                }
                catch (FormatException ex)
                {
             
                    OptionialParameter optionalParameter = new OptionialParameter();
                    optionalParameter.addTwoNumbers(firstNumber);
                    Console.ReadLine();
              
                    return;
                }
          
                catch (Exception ex)
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
