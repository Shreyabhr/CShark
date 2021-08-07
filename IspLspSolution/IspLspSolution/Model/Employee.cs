using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IspLspSolution.Model
{
    class Employee : IWork, IEat
    {
        public void StartEat()
        {
            Console.WriteLine("Employee starts eating");
        }

        public void StartWork()
        {
            Console.WriteLine("Employee starts working");
        }

        public void StopEat()
        {
            Console.WriteLine("Employee stops eating");
        }

        public void StopWork()
        {
            Console.WriteLine("Employee stops working");
        }
    }
}
