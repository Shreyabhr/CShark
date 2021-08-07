using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeSalaryApp.Model
{
    class Manager : Employee
    {

        public Manager(int eno, string ename, double basic) : base(eno, ename, basic) { }

        public double Hra
        {
            get
            {
                return _basic * 0.5;
            }
            
        }

        public double Ta
        {
            get
            {
                return _basic * 0.4;
            }
        }

        public override double CalculateCTC()
        {
            return Hra + Ta + Basic;
        }
    }
}
