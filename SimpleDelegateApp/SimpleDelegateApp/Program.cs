using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDelegateApp
{
    class Program
    {
        private delegate void DPrintMessage(String name);
        static void Main(string[] args)
        {
            DPrintMessage msg;
            msg = PrintHello;
            msg("Shreya");
            msg = PrintGoodBye;
            msg("Shreya");
            msg += PrintGoodBye;
            msg += PrintGoodBye;
            msg("Swabhav");
        }

        private static void PrintGoodBye(string name)
        {
            Console.WriteLine("GoodBye " + name);
        }

        private static void PrintHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
