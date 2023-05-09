using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassino
{
    //Here we are creating 2 constuctors one of them overloading the other and having them implement the exact same implementation that exists for exception
   public class FraudException:Exception
    {
        public FraudException()
            : base() { }
        public FraudException(string message)//overloading the constructory method
        : base(message) { }
        
        

    }
}
