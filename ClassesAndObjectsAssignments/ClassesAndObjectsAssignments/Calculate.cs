using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace ClassesAndObjectsAssignments
{
    //This class contains 3 methods each taking an integer and returning an integer. 
   public class Calculate
    {
        public int addFive(int num)
        {
            int result = 0;
            int x = 5;

            result = x + num;
            return result;
        }

        public int multiplyByTwo(int num)
        {
            int result = 0;
            int x = 2;

            result = x * num;
            return result;
        }
        public int modular(int num)
        {
            int result = 0;
            int x = 56;

            result = x % num;
            return result;
        }
    }
}

















































