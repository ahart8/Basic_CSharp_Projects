using System;

namespace BooleanComparisonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boolean comparison using a while statment
            bool flag = false;
            int i = 0;
            while (flag==false)
            {
             Console.WriteLine(i++);
                if (i == 10)
                {
                    flag = true;
                    Console.WriteLine("You counted to 10.\nPress any key to continue.");
                    Console.ReadKey();
                }
            }

            //Boolean comparison using a do while
            bool isFlag = false;
            int ii = 0;
            do
            {
                Console.WriteLine(ii++);
                if (ii == 10)
                {
                    flag = true;
                    Console.WriteLine("You counted to 10 again!\nPress any key to exit");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }
            while (isFlag == false);
        }
    }
}
