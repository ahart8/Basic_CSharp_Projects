using System;
using System.Collections.Generic;
using System.Text;

namespace MethodWithOptionalParameter
{
    class OptionialParameter
    {
        public int addTwoNumbers(int x, int y=8)
        {
           
            int sum = x + y;
            Console.WriteLine("The sum is: "+ sum);
            return sum;
        }
    }
}
