using AccountApp.Model;
using System;

namespace EventHandlingApp.Subscriber
{
    class RefreshBalanceProvider
    {
        public void RefreshBalance(Account acc)
        {
            Console.WriteLine(acc.Balance);
        }
    }
}
