using System;
using System.Text;




namespace ConstructorSubmissionAssignment
{
    
    class program
    {
        const string dogType = "Boston Terrier";
        static void Main(string[] args)
        {
            //Using var for the datatype allows c# to figure out what the data type is
            //Here we are using the child constructor and the age is set by default in the dog class
            var newDog = new Dog(dogType);
            //Here I am using the parent constructor and passing in the value of both parameters
            Dog newDog2 = new Dog("German Shepard", 5);
            Console.WriteLine(newDog.Breed+ " "+newDog.Age);
            Console.WriteLine(newDog2.Breed+" "+ newDog2.Age);
            Console.ReadLine();
        }
    }
}