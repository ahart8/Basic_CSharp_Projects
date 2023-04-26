using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace PolyMorphismAssignment
{
    public class Employee:Person, IQuittable
    {
       public void Quit()
        {
            Console.WriteLine("I quit");
            Console.ReadLine();
        } 
    }
}
