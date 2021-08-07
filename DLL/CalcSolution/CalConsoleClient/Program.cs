using CalcLib;
using System;
namespace CalConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            Console.WriteLine(cal.CheckEven(10));
            Console.WriteLine(cal.CheckPrime(3));
        }
    }
}
