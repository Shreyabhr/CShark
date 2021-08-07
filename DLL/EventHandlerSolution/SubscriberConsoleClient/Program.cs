using AccountApp.Model;
using EventHandlingApp.Subscriber;

namespace SubscriberConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(101, "abc", 1000);
            SmsServiceProvider sms = new SmsServiceProvider();
            ReceiptProvider receipt = new ReceiptProvider();
            acc.BalanceChanged += sms.SendSMS;
            acc.BalanceChanged += receipt.PrintReceipt;
            acc.Deposite(100);
        }
    }
}
