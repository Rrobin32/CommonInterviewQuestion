using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterviewQuestion
{
    internal class LINQLeftJoin
    {
        public static void Main(string[] args)
        {
            List<Students> students = new List<Students>();
            students.Add(new Students() { Id = 1, Name = "Rakesh" });
            students.Add(new Students() { Id = 2, Name = "Tapaswini" });
            students.Add(new Students() { Id = 3, Name = "Shantanu" });
            students.Add(new Students() { Id = 4, Name = "Sanjeev" });

            List<Subjects> subjects = new List<Subjects>(); ;
            subjects.Add(new Subjects() { Id = 1, StudentId = 1, Subject = "Hindi" });
            subjects.Add(new Subjects() { Id = 2, StudentId = 1, Subject = "English" });
            subjects.Add(new Subjects() { Id = 3, StudentId = 2, Subject = "Hindi" });
            subjects.Add(new Subjects() { Id = 4, StudentId = 2, Subject = "English" });

            var data = from Students in students
                       join sub in subjects on Students.Id equals sub.StudentId into subs
                       from Subject in subs.DefaultIfEmpty() select new Students { Id = Students.Id, Name = Students.Name };

            var dataInner = from Students in students
                       join sub in subjects on Students.Id equals sub.StudentId 
                       select new Students { Id = Students.Id, Name = Students.Name };


            Console.WriteLine("********* Left Join ************");
            foreach (Students stud in data)
            {
                Console.WriteLine("Id:" + stud.Id + ", Name:" + stud.Name);
            }

            Console.WriteLine();
            Console.WriteLine("********* Inner Join ************");

            foreach (Students stud in dataInner)
            {
                Console.WriteLine("Id:" + stud.Id + ", Name:" + stud.Name);
            }
        }
    }

    class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Subjects
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Subject { get; set; }
    }
}
