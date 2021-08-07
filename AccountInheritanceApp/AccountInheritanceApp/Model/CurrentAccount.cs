using AccountApp.Model;
using System;

namespace AccountInheritanceApp.Model
{
    class CurrentAccount : Account
    {
        private int _minBalance = 500;
        public CurrentAccount(int accNo, String accName, double balance) : base(accNo, accName, balance) { }

        public override void Withdraw(double amount)
        {
            if(Balance - amount < _minBalance)
            {
                throw new Exception("Balance Not Sufficient");
            }
            _balance -= amount;
        }
    }
}
