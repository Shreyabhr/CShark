using System;

namespace InheritanceExtension.Model
{
    class Robot : IWork
    {
        public void StartWork()
        {
            Console.WriteLine("robot starts working");

        }

        public void StopWork()
        {
            Console.WriteLine("robot stops working");
        }
    }
}
