using System;
using AccountInheritanceApp.Model;

namespace AccountInheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savAcc = new SavingsAccount(101, "abc", 1000);
            savAcc.Deposite(100);
            CurrentAccount currAcc = new CurrentAccount(102, "def", 1500);
            try
            {
                currAcc.Withdraw(1500);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(savAcc);
            Console.WriteLine(currAcc);
            
        }
    }
}
