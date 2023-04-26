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
            if (employee.employeeID.Equals(employee1.employeeID))
            {
                return true;
            }
            else
                return false;
        }
        public static bool operator !=(Employee employee, Employee employee1)
        {
            if (employee.employeeID.Equals(employee1.employeeID))
                return false;
            else
                return true;

          
        }

    }
}
