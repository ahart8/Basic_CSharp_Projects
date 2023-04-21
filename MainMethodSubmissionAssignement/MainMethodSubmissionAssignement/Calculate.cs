using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethodSubmissionAssignement
{
    //This class contains 3 methods each taking an integer and returning an integer. 
    public class Calculate
    {//This method takes in an integer and returns an integer. 
        public int addFive(int num)
        {
            int result = 0;
            int x = 5;

            result = x + num;
            return result;
        }
        //This method takes in a decimal and returns an integer
        public int addFive(decimal num)
        {
            int x = 0;
            int y = 0;
            int result = 0;
            x = addFive(x);
            Console.WriteLine(x);
            y = Convert.ToInt32(num);
            Console.WriteLine(y);
            result = x * y;
            return result;
        }

        public int addFive(string num)
        {
            int x = 0;
            int result = 0;
            x = addFive(x);
            int y = Convert.ToInt32(num);

            result = x % y;
            return result;
        }
    }
}