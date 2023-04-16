using System;
using System.Text;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {

        //Get user input and store in an array of strings. Display the value of the entered index.
        string[] strArray = { "Red", "Yellow", "Green", "Purple", "Blue" };
        bool isValid = false;
            
            while (!isValid)
            {
                Console.Write("Enter a number between 0 and 4: ");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i>=0 && i > 4)
                {
                    isValid = false;
                    Console.WriteLine("Enter a valid number");
                }
                if (i>=0 && i<=4)
                {
                    isValid = true;
                    Console.WriteLine("The color you selected is: "+strArray[i]);
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
            }
            }

        //Get user input and store in an array of integers. Display the value of the entered index.
            int[] intArray = { 3, 12, 88, 68,4500 };
             bool isValid1 = false;

            while (!isValid1)
            {
                Console.Write("Enter a number between 0 and 4: ");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i >= 0 && i > 4)
                {
                    isValid1 = false;
                    Console.WriteLine("Enter a valid number");
                 }
                if (i >= 0 && i <= 4)
                {
                    isValid1 = true;
                    Console.WriteLine("The number you selected is: " + intArray[i]);
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
            }

            //Get user input and store in a list. Display the value of the entered index.
            bool isValid2 = false;

            while (!isValid2)
            {
               Console.Write("Enter a number between 0 and 4: ");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i >= 0 && i > 4)
                {
                    isValid1 = false;

                    Console.WriteLine("Enter a valid number");
                }
                if (i >= 0 && i <= 4)
                {
                    isValid1 = true;
                    List<string> strArray1 = new List<string>();
                    strArray1.Add("Red");
                    strArray1.Add("Yellow");
                    strArray1.Add("Green");
                    strArray1.Add("Purple");
                    strArray1.Add("Blue");

                    Console.WriteLine("The color you selected is: " + strArray1[i]);
                Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                    System.Environment.Exit(0);
            }
        }

    }
}

