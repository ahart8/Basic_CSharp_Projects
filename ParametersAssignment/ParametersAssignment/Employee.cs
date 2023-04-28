using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ParametersAssignment 
{
    //Make the employee class take a generic type parameter
    class Employee<T>
    {
       //Add a property to the Emplayee Class called thing and have its datatype be a generic list
        public List<T>Thing {get;set;}
        
    }
}
