using System;
using System.Collections.Generic;

namespace EmployeeAnalyzerApp.Model
{
    class EmployeeDataAnalyzer
    {
        private string[] _employeesData;
        private List<Employee> _employee;

        public EmployeeDataAnalyzer(string[] employeesData)
        {
            _employeesData = employeesData;
            _employee = new List<Employee>();
        }

        public void InsertEmployees()
        {
            foreach (string employee in _employeesData)
            {
                string[] data = employee.Split(',');
                ReplaceNullValue(data);
                _employee.Add(new Employee(Convert.ToInt32(data[0]), data[1], data[2], Convert.ToInt32(data[3]), data[4], Convert.ToDouble(data[5]), Convert.ToDouble(data[6]), Convert.ToInt32(data[7])));            
            }
        }

        private void ReplaceNullValue(string[] data)
        {
            for(int i = 0; i < data.Length; i++)
            {
                data[i] = (data[i] == "NULL") ? "0" : data[i];
            }
        }

        public Employee FindMaxSalary()
        {
            Employee emp = null;
            double max_sal = 0;
            foreach(Employee person in _employee)
            {
                if(person.Salary > max_sal)
                {
                    max_sal = person.Salary;
                    emp = person;
                }
            }
            return emp;
        }

        public Dictionary<int, List<string>> GetEmployeeByDepartment()
        {
            Dictionary<int, List<string>> departmentWiseEmployee = new Dictionary<int, List<string>>();
            foreach(Employee emp in _employee)
            {
                if (!departmentWiseEmployee.ContainsKey(emp.DeptNo))
                {
                    List<string> people = new List<string>();
                    people.Add(emp.EmployeeName);
                    departmentWiseEmployee.Add(emp.DeptNo, people);
                    continue;
                }
                departmentWiseEmployee[emp.DeptNo].Add(emp.EmployeeName);
            }
            return departmentWiseEmployee;
        }

        public Dictionary<string, List<string>> GetEmployeeByDesignation()
        {
            Dictionary<string, List<string>> designationWiseEmployee = new Dictionary<string, List<string>>();
            foreach (Employee emp in _employee)
            {
                if (!designationWiseEmployee.ContainsKey(emp.Designation))
                {
                    List<string> people = new List<string>();
                    people.Add(emp.EmployeeName);
                    designationWiseEmployee.Add(emp.Designation, people);
                    continue;
                }
                designationWiseEmployee[emp.Designation].Add(emp.EmployeeName);
            }
            return designationWiseEmployee;
        }
    }
}
