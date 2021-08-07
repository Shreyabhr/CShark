using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventHandlingApp.Subscriber
{
    class SmsServiceProvider
    {
        public void SendSMS(Account acc)
        {
            Console.WriteLine("Balance is changed: " + acc.Balance);
        }
    }
}
