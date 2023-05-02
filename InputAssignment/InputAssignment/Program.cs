using System;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string logText= Console.ReadLine();
            File.WriteAllText(@"C:\Users\amy\Desktop\logEntry.txt", logText);
            string fileData =File.ReadAllText(@"C:\Users\amy\Desktop\logEntry.txt");
            Console.WriteLine(fileData);
            Console.ReadLine();
        }
    }
}
