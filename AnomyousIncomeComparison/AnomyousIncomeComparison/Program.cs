using System;


    class Program
    {

    public static double getSalary(double hours, double rate)
    {
        return hours * rate * 52;
    }


    static void Main(string[] args)
        {
        Console.WriteLine("Person 1");
        Console.Write("Enter your hourly rate: ");
        double hourlyRate1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the number of hours worked per week: ");
        double hoursWorked1 = Convert.ToDouble(Console.ReadLine());
        double annualSalary1 = getSalary(hoursWorked1, hourlyRate1);
              
        Console.WriteLine("Person 2");
        Console.Write("Enter your hourly rate: ");
        double hourlyRate2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the number of hours worked per week: ");
        double hoursWorked2 = Convert.ToDouble(Console.ReadLine());
        double annualSalary2 = getSalary(hoursWorked2, hourlyRate2);


        Console.WriteLine("Annual salary of Person 1\n" + annualSalary1);
        Console.WriteLine("Annual Salary of Person 2\n " + annualSalary2);

        Console.WriteLine("Does Person 1 make more money than Person 2 ?");
        bool makesMore = annualSalary1 > annualSalary2;
        Console.WriteLine(makesMore.ToString());
    }
    }

