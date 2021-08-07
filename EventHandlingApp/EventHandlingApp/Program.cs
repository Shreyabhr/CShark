using AccountApp.Model;
using EventHandlingApp.Subscriber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventHandlingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(101, "abc", 1000);
            SmsServiceProvider sms = new SmsServiceProvider();
            acc.BalanceChanged += sms.SendSMS;
            acc.Deposite(100);
        }
    }
}
