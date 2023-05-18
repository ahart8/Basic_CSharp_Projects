using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
           using(var db=new StudentContext())
            {
                //Create and save a new student
                Console.Write("Enter the students name: ");
                var name = Console.ReadLine();

                var student = new Student { StudentName = name };

                db.Students.Add(student);
                db.SaveChanges();

                //display all of the studends in the database
                var query = from b in db.Students
                            orderby b.StudentName
                            select b;
                foreach (var item in query)
                {
                    Console.WriteLine(item.StudentName);
                }
               
                Console.ReadLine();
            }
        }
    }
    
    public class Student
    {
        public int StudentId { get; set;}
        public string StudentName { get; set; }
        public Grade Grade { get; set; }
    }

    public class Grade
    {
        public int GradeId { get; set; }
      
        public string GradeEarned { get; set; }
    }
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }    

}
