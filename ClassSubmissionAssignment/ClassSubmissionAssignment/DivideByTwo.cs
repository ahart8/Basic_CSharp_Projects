using System;
using System.Collections.Generic;
using System.Text;

namespace ClassSubmissionAssignment
{
   class DivideByTwo
    { 
        //This method takes in an integer and divides it by 2 and displays it to the screen. It does not return a value because it is void
        public void divideByTwo(int num)
        {
            int ret=0;
            ret = num / 2;
            Console.WriteLine("Your number divided by 2 is: "+ret);
          
        }
        
    }
}
