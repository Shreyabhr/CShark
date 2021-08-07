using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeSalaryApp.Model
{
    abstract class Employee
    {
        private int _eno;
        private String _ename;
        protected double _basic;

        public Employee(int eno, String ename, double basic)
        {
            _eno = eno;
            _ename = ename;
            _basic = basic;
        }

        public int EmployeeId{
            get
            {
                return _eno;
            }
        }

        public String EmployeeName
        {
            get
            {
                return _ename;
            }
        }

        public double Basic
        {
            get
            {
                return _basic;
            }
        }

        public abstract double CalculateCTC();

    }
}
