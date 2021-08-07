using System;
using AccountApp.Model;

namespace AccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(101, "abc", 1000);
            Account acc2 = new Account(102, "def", 3000);
            acc.Deposite(500);
            try
            {
                acc.Withdraw(1600);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(acc);
            Console.WriteLine(acc2);
            Console.WriteLine("No of account created: " + Account.HeadCount);
        }
    }
}
