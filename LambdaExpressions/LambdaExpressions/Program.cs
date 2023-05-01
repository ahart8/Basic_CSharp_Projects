using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();
            Employee emp4 = new Employee();
            Employee emp5 = new Employee();
            Employee emp6 = new Employee();
            Employee emp7 = new Employee();
            Employee emp8 = new Employee();

            List<Employee> employeeList = new List<Employee>();

            emp.FirstName = "Amy";
            emp.LastName="Hart";
            emp.Id = 12;
            employeeList.Add(emp);

            emp1.FirstName = "Floyd";
            emp1.LastName = "Hart";
            emp1.Id = 12;
            employeeList.Add(emp1);

            emp2.FirstName = "Joe";
            emp2.LastName = "Smith";
            emp2.Id = 2;
            employeeList.Add(emp2);

            emp3.FirstName = "Shelly";
            emp3.LastName = "Phipps";
            emp3.Id = 1;
            employeeList.Add(emp3);
                        
            emp4.FirstName = "Jim";
            emp4.LastName = "Shoe";
            emp4.Id = 12;
            employeeList.Add(emp4); 
                        
            emp5.FirstName = "Amy";
            emp5.LastName = "Hart";
            emp5.Id = 12;
            employeeList.Add(emp5);

            emp6.FirstName = "Joe";
            emp6.LastName = "Jackson";
            emp6.Id = 12;
            employeeList.Add(emp6);

            emp7.FirstName = "Bob";
            emp7.LastName = "Rice";
            emp7.Id = 8;
            employeeList.Add(emp7);

            emp8.FirstName = "Carl";
            emp8.LastName = "Budding";
            emp8.Id = 12;
            employeeList.Add(emp8);

            List<Employee> joeList = new List<Employee>();
            List<Employee> joeList2 = employeeList.Where(x => x.FirstName == "Joe").ToList();
            List<Employee> idList= employeeList.Where(x => x.Id > 5).ToList();
                    

            int counter = 0;
            foreach (Employee employee in employeeList)
            {
                              
                
                if (employee.FirstName=="Joe")
                {
                    Console.WriteLine(employee.FirstName +" "+ employee.LastName + " "+employee.Id);
                    joeList.Add(employee);
                }
                
                counter++;
            }

           foreach(Employee employee in joeList2)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Id);
            }


            foreach (Employee employee in idList)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Id);
            }
      
            Console.ReadLine();
        }
              
       
    }
}