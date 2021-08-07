using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
