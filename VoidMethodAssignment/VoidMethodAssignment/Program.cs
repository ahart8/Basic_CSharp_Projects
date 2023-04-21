using System;

namespace VoidMethodAssignment
{
    class Program
    {
        static void Main()
        {
            int x = 5;
            int y = 10;
            //Instanciate the class in the main method
            AddTwoNumbers myNumbers = new AddTwoNumbers();

            //Call the method in the class specifying the parameters by name
            myNumbers.myMethod(x: x, y:y);
            Console.ReadLine();
        }
    }
}
