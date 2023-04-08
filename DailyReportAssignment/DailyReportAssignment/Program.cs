using System;



class Program
{
    static void Main(string[] args)
    {
        //DISPLAY DR HEADING
        Console.WriteLine("The Techacademy \nStudent Daily Report\n\n");
        
        //ASK NAME AND STORE AS A STRING
        Console.WriteLine("What is your Name\n");
        string yourName = Console.ReadLine();
              
        //ASK COURSE AND STORE AS A STRING
        Console.WriteLine("What course are you on?\n");
        string theCourse = Console.ReadLine();
  

        //ASK PAGE AND STORE AS AND STORE AS AN INT
        Console.WriteLine("What pageNumber are you on?\n");
        string pageNumber = Console.ReadLine();
        int pgNum = Convert.ToInt32(pageNumber);

        //ASK IF NNE HELP AND STORE AND STORE AS BOOLEAN
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"\n");
        string needHelp = Console.ReadLine();
        Convert.ToBoolean(needHelp);
      
        //ASK FOR POSITIVE EXPERRIENCES AND STORE AS A STRING
        Console.WriteLine("Where there any positive experriences that you would like to share?\n");
        string shareExperrience=Console.ReadLine();

        //ASK FOR STUDY HOURS AND STORE AS INTEGER
        Console.WriteLine("How many hours did you study today?\n");
        string studyHours = Console.ReadLine();
        Convert.ToInt32(studyHours);

        Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a greate day!");

        //EXIT GRACEFULLY
        Environment.Exit(0);
      
    }
}

