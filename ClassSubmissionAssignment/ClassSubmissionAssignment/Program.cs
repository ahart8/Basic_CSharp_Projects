using System;

namespace ClassSubmissionAssignment
{
    class Program
    {
       
        public static void Main(string[] args)
        {
          
            //Instanciate the class
            DivideByTwo number = new DivideByTwo();
            Console.Write("Enter a number that can be divided evenly by 2: ");
            int myNumber = Convert.ToInt32(Console.ReadLine());
               
            //Call the method on the number entered
            number.divideByTwo(myNumber);
            //Call the AddNumbers method 
            AddNumbers();
            
           //Create a method with output paramenters
            void Output(int number1, int number2, out int result)
            {
                result = number1 + number2;
            }

            void AddNumbers()
            {
                int ret;
                Output(2, 5, out ret);
                Console.WriteLine("The output is: "+ret);
                Console.ReadKey();
            }

        }

        //Overload a method
       
    }
}
