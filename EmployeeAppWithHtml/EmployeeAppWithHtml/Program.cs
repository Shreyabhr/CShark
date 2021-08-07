using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeSalaryApp.Model;

namespace EmployeeAppWithHtml
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Analyst(101, "abc", 3400);
            Employee emp2 = new Developer(102, "def", 8000);
            Employee emp3 = new Manager(103, "ghi", 9000);
            List<Employee> employees = new List<Employee>();
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            RenderHtml html = new RenderHtml();
            html.RenderHtmlFile(employees);
        }
    }
}
