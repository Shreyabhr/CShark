using EmployeeSalaryApp.Model;
using System;
using System.Reflection;

namespace EmployeeSalaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Analyst(101, "abc", 3400);
            Employee emp2 = new Developer(102, "def", 8000);
            Employee emp3 = new Manager(103, "ghi", 9000);
            PrintInfoEmployee(emp1);
            PrintInfoEmployee(emp2);
            PrintInfoEmployee(emp3);
        }

        private static void PrintInfoEmployee(Employee employee)
        {
            var type = employee.GetType();
            PropertyInfo[] propInfos = type.GetProperties();
            foreach (PropertyInfo method in propInfos)
            {
                Console.WriteLine(method.Name + ": " + method.GetValue(employee, null));
            }
            Console.WriteLine("CTC: " + employee.CalculateCTC());
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
