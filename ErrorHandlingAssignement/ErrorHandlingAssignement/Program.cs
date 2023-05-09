using System;

namespace ErrorHandlingAssignement
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool validAnswer = false;
            int age = 0;
            while (!validAnswer)
            {
                Console.Write("Enter your age: ");
                validAnswer = int.TryParse(Console.ReadLine(), out age);
                if (!validAnswer) Console.WriteLine("Enter digits only. No decimals");
             
            }
            if (age < 0)
            {
                throw new HandleError("No Negatives allowed");

            }
            //try catch will go here  around the method call

            try
            {
                myMethod(age);
            }
          // catch(HandleError)
           // {
             //   Console.WriteLine("I can't believe it is not butter");
          // }
            catch (Exception)
            {
                Console.WriteLine("An error has occurred");

            }
            
           
             static void myMethod(int ageEntered)
            {
                DateTime currYear = DateTime.Parse(DateTime.Now.ToString());
                int currentYear = Convert.ToInt32(currYear.Year);
                int yearOfBirth = currentYear - ageEntered;
               
                Console.WriteLine("The year of birth is: "+yearOfBirth);
                Console.ReadLine();
                return;
              
            }

        }
    }
    }         
    
