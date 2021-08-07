using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceExtension.Model
{
    class Employee : IWorkEat
    {
        public void StartEat()
        {
            Console.WriteLine("Employee is eating");
        }

        public void StartWork()
        {
            Console.WriteLine("Employee is working");
        }

        public void StopEat()
        {
            Console.WriteLine("Employee stopped eating");
        }

        public void StopWork()
        {
            Console.WriteLine("Employee stopped working");
        }
    }
}
