using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IspLspViolation.Model
{
    class Robots : IWorkable
    {
        public void StartEat()
        {
            throw new Exception("Robot cannot eat");
        }

        public void StartWork()
        {
            Console.WriteLine("Robot starts working");
        }

        public void StopEat()
        {
            throw new Exception("Robot cannot eat");
        }

        public void StopWork()
        {
            Console.WriteLine("Robot stops working");
        }
    }
}
