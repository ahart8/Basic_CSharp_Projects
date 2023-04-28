using System;

namespace ParsiningEnumsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Enter the current day");
                string input = Console.ReadLine();
                string theDay = input.ToLower();
                //Declair and Enum
                 DaysOfTheWeek getParse;

                //TryParse to see if the value entered can be parsed into the enum
                //Just trying to convert into the raw enum data type
                //Output the result into another variable
                bool checkParse = Enum.TryParse(theDay, out getParse);


            try 
            { 
                    if (checkParse)
                    {
                        Console.WriteLine(getParse);
                    }
                    else
                    {
                        throw new Exception();
                    }

            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter the actual day of the week");
            }
            finally
            {
                Console.ReadLine();
            }
        }
        //Create an enum for days of the week
        public enum DaysOfTheWeek
        {
            monday,
            tuesday,
            wednesday,
            friday,
            thursday,
            saturday,
            sunday
        }
       
        
        
    }
}
