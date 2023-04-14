using System;

    class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("what is your favorite number");
        int favNum = Convert.ToInt32(Console.ReadLine());


        string result = favNum == 12 ? "You have an awesome favorite number" :"You do not have an awesome favorite number. ";
        Console.WriteLine(result);
      

        //int currentTemperature = 75;
        //int roomTemperature = 70;

        //Console.WriteLine("Hi, what is your name");
        //string name = Console.ReadLine();


        //Console.WriteLine("Hi, " + name + ", what is hte temperature where you are?");
        //int currentTemperature = Convert.ToInt32(Console.ReadLine());

 


        //if (currentTemperature == roomTemperature)
        //{
        //    Console.WriteLine("Is is exactly room temperature");
        //}
        //else if (currentTemperature > roomTemperature )
        //{
        //  Console.WriteLine("It is warmer than room temperature");
        //}

        //else if (currentTemperature < roomTemperature)
        //{
        //    Console.WriteLine("Is is colder than temperature");
        //}
        //else
        //{
        //    Console.WriteLine("something went wrong")
        //}
        //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp.";

        //Console.WriteLine(comparisonResult);
    }

    }

