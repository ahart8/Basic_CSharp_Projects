using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorHandlingAssignement
{
    class HandleError : Exception
    {
        public HandleError()
            : base() { }
        public HandleError(string message)
            : base(message) { }
    }
}
