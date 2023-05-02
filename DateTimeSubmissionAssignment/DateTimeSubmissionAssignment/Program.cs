using System;

namespace DateTimeSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print the current date time to the screen
            Console.WriteLine("The current date and time is" ,DateTime.Now);
            //Prompt the user to imput hours to add 
            Console.Write("Enter a number: ");
            //Get number of hours to add to the current date time from the user
            int numberHours =Convert.ToInt32(Console.ReadLine());
            //Get the current date time
            DateTime dateTime = DateTime.Now;
            //Add the number of hour entered by the user to the current date time
            DateTime dateTime1 = dateTime.AddHours(numberHours);
            //Print the answer to the screen
            Console.WriteLine("The exact time in "+numberHours + " hours will be: "+dateTime1);
            //Make the screen pause so you can read the output
            Console.ReadLine();
        }
    }
}
