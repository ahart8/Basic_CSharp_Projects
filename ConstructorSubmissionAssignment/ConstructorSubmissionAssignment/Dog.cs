using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorSubmissionAssignment
{
    class Dog
    {
        //This construtor inherits from the previous constructor 
         
        public Dog(string dogBreed):this(dogBreed,1)
        {

        }
        public Dog(string dogBreed, int dogAge)
        {
            Breed = dogBreed;
            Age = dogAge;
            
        }
        public string Breed { get; set; }
        public int Age { get; set; }
    }
}
