using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace PolyMorphismAssignment
{
    class Program
    {
        
            static void Main(string[] args)
            {
               IQuittable employee = new Employee();
               employee.Quit();

            }
        
    }
}
