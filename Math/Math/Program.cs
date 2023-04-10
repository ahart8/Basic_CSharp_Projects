using System;


    class Program
    {
        static void Main(string[] args)
        {
        //Add two numbers
        int numOne = 1;
        int numTwo =4;
        int total = numOne + numTwo;

        Console.WriteLine(numOne +"+"+numTwo + "="+total);

        //Subtract two numbers 
        int num1 = 8;
        int num2 = 5;
        int difference = num1 - num2;

        Console.WriteLine(num1 +"-"+num2 + "="+difference);

        //Multiply 2 numbers
        int numberOne = 4;
        int numberTwo = 2;
        int product = numberOne * numberTwo;

        Console.WriteLine(numberOne + "*" + numberTwo + "=" + product);

        //Divide 2 numbers
        int number1 = 15;
        int number2 = 3;
        int quotent = 15 / 3;

        Console.WriteLine(number1 + "/" + number2 + "=" + quotent);

        //Concatenated a string and an int
        string word="blue";
        int number = 8;

        Console.WriteLine  (word + number);

        //Add 2 numbers implicitly
        int total2 = 5 + 10;
        int otherTotal = 12 + 22;
        int combined = total2 + otherTotal;

        Console.WriteLine(combined);

        //subtract 2 numbers casting
        int difference2 = 10 - 5;
        Console.WriteLine("Ten minue five=" + difference2.ToString());

  
        //Multiply 2 numbers
        int product2 = 10 * 5;
        Console.WriteLine(product2);

        //Divide
        double quotent2 = 100.0 / 17.0;
        Console.WriteLine(quotent2);

        


        //Modular arithemic if it has a remander the number is odd if it has not remainder it is even
        int remainder = 10 % 2;
        Console.WriteLine(remainder);
       

        bool trueOrFalse = 12 < 5;
        Console.Write(trueOrFalse.ToString());
    
        //Comparison Operator
        int roomTemperature = 70;
        int currentTemperature = 72;
        bool isWarm = currentTemperature > roomTemperature;
        Console.WriteLine(isWarm);
        Console.ReadLine();




    }
}

