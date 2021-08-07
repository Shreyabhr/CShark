using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventHandlingApp.Subscriber
{
    class ReceiptProvider
    {
        public void PrintReceipt(Account acc)
        {
            Console.WriteLine("Printing receipt\nAccount No." + acc.AccNo + "Account NAme: " + acc.AccName + "Balance: " + acc.Balance);
        }
    }
}
