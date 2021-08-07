using IspLspSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IspLspSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintIWork(new Employee());
            PrintIEat(new Employee());
            PrintIWork(new Robots());
        }

        private static void PrintIEat(IEat person)
        {
            person.StartEat();
            person.StopEat();
        }

        private static void PrintIWork(IWork person)
        {
            person.StartWork();
            person.StopWork();
        }
    }
}
