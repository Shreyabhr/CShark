using EmployeeAnalyzerApp.Model;
using System;
using System.Collections.Generic;

namespace EmployeeAnalyzerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1)Load from local\n2)Load from URL");
            int choice = Convert.ToInt32(Console.ReadLine());
            string[] data = { };
            IFileLoader file;
            if(choice == 1)
            {
                file = new LocalFileLoader();
                data = file.LoadFile("dataFile.txt");
            }
            else if(choice == 2)
            {
                file = new URLLoader();
                data = file.LoadFile("https://swabhav-tech.firebaseapp.com//emp.txt");
            }

            EmployeeDataAnalyzer employee = new EmployeeDataAnalyzer(data);
            employee.InsertEmployees();

            Employee highestpaid = employee.FindMaxSalary();
            Console.WriteLine("Employee with highest salary " + highestpaid.EmployeeName + ":" + highestpaid.Salary);

            Dictionary<int, List<string>> departmentWiseEmployee = employee.GetEmployeeByDepartment();
            foreach (KeyValuePair<int, List<string>> emp in departmentWiseEmployee)
            {
                Console.WriteLine("Employee with id: {0} are: {1}",
                emp.Key, emp.Value.Count);
            }

            Dictionary<string, List<string>> designationWiseEmployee = employee.GetEmployeeByDesignation();
            foreach (KeyValuePair<string, List<string>> emp in designationWiseEmployee)
            {
                Console.WriteLine("Employee with designation: {0} are: {1}",
                emp.Key, emp.Value.Count);
            }
        }
    }
}
