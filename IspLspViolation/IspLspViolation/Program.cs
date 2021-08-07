using IspLspViolation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IspLspViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintIWorkable(new Employee());
            PrintIWorkable(new Robots());
        }

        private static void PrintIWorkable(IWorkable person)
        {
            try
            {
                person.StartEat();
                person.StopEat();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            person.StartWork();
            person.StopWork();
        }
    }
}
