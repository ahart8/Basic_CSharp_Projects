using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsSubmissionAssignment
{
    class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int employeeID { get; set; }


        public static bool operator ==(Employee employee, Employee employee1)
        {
            return employee.employeeID == employee1.employeeID;
        }
        public static bool operator !=(Employee employee, Employee employee1)
        {
            return employee.employeeID != employee1.employeeID;


        }

    }
}
