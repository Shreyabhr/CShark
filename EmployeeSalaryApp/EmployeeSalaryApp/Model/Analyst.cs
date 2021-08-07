using System;

namespace EmployeeSalaryApp.Model
{
    class Analyst : Employee
    {
        public Analyst(int eno, String ename, double basic) : base(eno, ename, basic) { }

        public double Perks
        {
            get
            {
                return _basic * 0.3;
            }
        }

        public override double CalculateCTC()
        {
            return Perks + Basic;
        }
    }
}
