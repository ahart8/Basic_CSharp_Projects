using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your first name");
            string date = DateTime.Today.ToShortDateString();
            string uname = Console.ReadLine();
            string msg = $"\nWelcome back {uname}.Today is {date}.";
            Console.WriteLine(msg);

            //Get text out of a file and store in a array
            string path = @"C:\Users\amy\Documents\Basic_CSharp_Projects\Scores\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);

            double tScore = 0.0;
            Console.WriteLine("\nStuden Score: \n");
            foreach (string line in lines) 
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;

            }
            double avgScore = tScore / lines.Length;
            Console.WriteLine("\nTotal of "+lines.Length+" student scores. \tAverage score: "+avgScore);



            Console.WriteLine("\n\nPress any key to exit");
            Console.ReadLine();
        }
    }
}
