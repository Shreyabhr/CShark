using System;

namespace IspLspSolution.Model
{
    class Robots : IWork
    {
        public void StartWork()
        {
            Console.WriteLine("Robot starts working");
        }

        public void StopWork()
        {
            Console.WriteLine("Robot stops working");
        }
    }
}
