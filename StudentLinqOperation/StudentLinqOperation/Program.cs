using StudentLinqOperation.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentLinqOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            students.Add(new Student(1, "Jenny", 9.7,"kalyan"));
            students.Add(new Student(2, "Joseph", 6.5, "mumbai"));
            students.Add(new Student(3, "Alex", 5.3, "kalyan"));
            students.Add(new Student(4, "Harris", 4.3, "kalyan"));
            students.Add(new Student(5, "Taylor", 8.3, "thane"));
            students.Add(new Student(6, "Smith", 7.9, "delhi"));
            students.Add(new Student(7, "Natasa", 2.3, "mumbai"));
            students.Add(new Student(8, "David", 9.2, "kalyan"));
            students.Add(new Student(9, "Harry", 8.3, "mumbai"));
            students.Add(new Student(10, "Nicolash", 6.3, "panvel"));

            var highestCgpa = StudentsHighCgpa(students);
            Console.WriteLine("5 students with highest CGPA");
            foreach(var student in highestCgpa)
            {
                Console.WriteLine(student.Name);
            }

            var locationMumbai = students.Where(s => s.Location == "mumbai");
            Console.WriteLine("students with location mumbai");
            foreach (var student in locationMumbai)
            {
                Console.WriteLine(student.Name);
            }

            var StudentInAscendingOrder = StudentsInMumbaiInOrder(students);
            Console.WriteLine("students with location mumbai in ascending order");
            foreach (var student in StudentInAscendingOrder)
            {
                Console.WriteLine(student.Name);
            }

            var details = students.Select(s => new { s.Name, s.Cgpa });
            Console.WriteLine("students with name and cgpa");
            foreach (var student in details)
            {
                Console.WriteLine(student);
            }
        }
        private static IOrderedEnumerable<Student> StudentsInMumbaiInOrder(List<Student> students)
        {
            return students.Where(s => s.Location == "mumbai")
                            .OrderBy(s => s.Name);
        }

        private static IOrderedEnumerable<Student> StudentsHighCgpa(List<Student> students)
        {
            return students.Take(5)
                           .OrderByDescending(s => s.Cgpa);
        }
    }
}
