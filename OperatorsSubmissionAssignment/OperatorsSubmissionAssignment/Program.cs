using System;

namespace OperatorsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciate 2 employee objects
            Employee employee = new Employee();
            employee.employeeID = 1;
            Employee employee1 = new Employee();
            employee1.employeeID = 2;
            //Complare the objects using the logic of the Equals method
            Console.WriteLine(employee.employeeID.Equals(employee1.employeeID) ? "Employee Id's are different." : "Employee Id's match.");

            Console.ReadLine();
          

        }
    }
}
