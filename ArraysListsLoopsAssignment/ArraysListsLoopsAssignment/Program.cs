using System;
using System.Collections.Generic;
using System.Text;

class Program
    {
        static void Main()
        {
            string[] songArray = new string[5];
            int i;
            do
            {

                for (i = 0; i<5; i++)
                {
                    Console.Write("Enter the names of 5 your favorite songs:");
                    songArray[i] = Console.ReadLine();           
                }
            
            } while (i < 5);
       
                foreach (string song in songArray)
                {
                    Console.WriteLine(song);
                }
        
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                System.Environment.Exit(0);
        }
    }

