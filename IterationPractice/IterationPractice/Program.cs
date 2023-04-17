using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main()
    {
        int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        for (int i = 0; i < testScores.Length; i++)
        {
            if (testScores[i] > 85)
            {
                Console.WriteLine("Passing test score: " + testScores[i]);
            }
        }
        Console.ReadLine();

        string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

        for (int j = 0; j < names.Length; j++)
        {
            Console.WriteLine(names[j]);

        }
        Console.ReadLine();


        List<int> testScores1 = new List<int>();
        testScores1.Add(98);
        testScores1.Add(99);
        testScores1.Add(81);
        testScores1.Add(72);
        testScores1.Add(70);

        foreach(int score in testScores1)
        {
            if(score>85)
            {
                Console.WriteLine("Passing test score: " + score);
            }
        }
        Console.ReadLine();



        List<string> names1=new List<string> { "Jesse", "Erik", "Daniel", "Adam" };
        foreach (string name in names1)
        {
            Console.WriteLine(name);

        }  
        Console.ReadLine();

         List<int> testScores2 = new List<int>() { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
        List<int> passingScores = new List<int>();
        foreach(int score2 in testScores2)
        {
            if (score2>85)
            {
                passingScores.Add(score2);
            }
        }
        Console.WriteLine(passingScores.Count);
        Console.ReadLine();
    }

}
