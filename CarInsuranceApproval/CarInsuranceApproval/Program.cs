using System;



    class Program
    {
        static void Main(string[] args)
        {
        //Get the age and convert to an int
        Console.Write("What is your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        //Get DUI status and convert the string to a bool
        Console.Write("Have you ever had a DUI? Enter True or False: ");
        bool dui = Convert.ToBoolean(Console.ReadLine());
        
        //Get the number of speeding tickets
        Console.Write("How many speeding tickets do you have?: ");
        int tickets = Convert.ToInt32(Console.ReadLine());

        //Check to see if they qualify and display on the screen
        bool qualified=(age>=15 && !dui && tickets<=3);
        Console.WriteLine(qualified);
        Console.ReadLine();
        }
    }

