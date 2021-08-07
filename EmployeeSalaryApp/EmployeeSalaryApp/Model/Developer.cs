using System;

namespace EmployeeSalaryApp.Model
{
    class Developer : Employee
    {
        public Developer(int eno, String ename, double basic) : base(eno, ename, basic) { }

        public double ProjectAllowance{
            get
            {
                return _basic * 0.3;
            }
        }

        public double PA
        {
            get
            {
                return _basic * 0.4 ;
            }
        }

        public override double CalculateCTC()
        {
            return PA + ProjectAllowance + Basic;
        }
    }
}
