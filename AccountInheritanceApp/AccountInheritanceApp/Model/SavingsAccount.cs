using AccountApp.Model;
using System;

namespace AccountInheritanceApp.Model
{
    class SavingsAccount : Account
    {
        private double _minBalance = 1000;

        public SavingsAccount(int accNo, String accName, double balance) : base(accNo, accName, balance) { }

        public override void Withdraw(double amount)
        {
            if(Balance - amount <= _minBalance)
            {
                throw new Exception("Balance Not Sufficient");
            }
            _balance -= amount;           
        }
    }
}
