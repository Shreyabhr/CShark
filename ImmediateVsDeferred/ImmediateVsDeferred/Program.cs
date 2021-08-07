using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmediateVsDeferred
{
    class Program
    {
        static void Main(string[] args)
        {

            var students = new List<Student>();
            students.Add(new Student(1, "Jenny", 9.7, "kalyan"));
            students.Add(new Student(2, "Joseph", 6.5, "mumbai"));
            students.Add(new Student(3, "Alex", 5.3, "kalyan"));
            students.Add(new Student(4, "Harris", 4.3, "kalyan"));
            students.Add(new Student(5, "Taylor", 8.3, "thane"));
            students.Add(new Student(6, "Smith", 7.9, "delhi"));
            students.Add(new Student(7, "Natasa", 2.3, "mumbai"));
            students.Add(new Student(8, "David", 9.2, "kalyan"));
            students.Add(new Student(9, "Harry", 8.3, "mumbai"));

            //deferred execution

            var studentsInMumbai = students.Where(s => s.Location == "mumbai")
                                           .OrderBy(s => s.Name);

            students.Add(new Student(10, "Nicolash", 6.3, "mumbai"));

            foreach (var student in studentsInMumbai)
            {
                Console.WriteLine(student.Name);
            }

            //immediate execution

            var studentWithHighCgpa = students.Take(5)
                                              .OrderByDescending(s => s.Cgpa).ToArray();

            students.Add(new Student(10, "Nicolash", 6.3, "mumbai"));
            foreach (var student in studentWithHighCgpa)
            {
                Console.WriteLine(student.Name);
            }

        }
    }
}
