using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    public class ErrorHandling:Exception //inherits from the exception class
    {
        public NegativeNumberException()
            : base() { }
        public NegativeNumberException(string message)//overloading the constructory method
        : base(message) { }
    }
}
