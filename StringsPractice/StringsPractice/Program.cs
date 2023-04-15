using System;
using System.Text;

namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Escape sequences
            //string name = "Amy";
            //string quote = " The man said,\"Hello\", Jessie\n Hello on a new line\n\t Hello on a tab";
            //string fileName = "C:\\Users\\Amy";
            //string fileName2 = @"C:\users\amy";

            ////String functions
            ////Contains
            //bool trueOrFalse = name.Contains("A");
            //trueOrFalse = name.EndsWith("b");

            //int length = name.Length;

            //name=name.ToUpper();

            //Console.WriteLine(quote);
            //Console.WriteLine(fileName);
            //Console.WriteLine(fileName2);
            //Console.WriteLine(trueOrFalse);
            //Console.WriteLine(length);
            //Console.WriteLine(name);
            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Amy");
            Console.WriteLine(sb);

            Console.ReadLine();


        }
    }
}
