using System;

namespace AccountApp.Model
{
    abstract class Account
    {
        private int _accNo;
        private String _accName;
        protected double _balance;

        public Account(int accNo, String accName)
        {
            _accNo = accNo;
            _accName = accName;
        }

        public Account(int accNo, String accName, double balance) : this(accNo,accName)
        {
            _balance = balance;
        }

        public int AccNo
        {
            get
            {
                return _accNo;
            }
            set
            {
                _accNo = value;
            }
        }

        public String AccName
        {
            get
            {
                return _accName;
            }
            set
            {
                _accName = value;
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
        }

        public void Deposite(double amount)
        {
            _balance += amount;
        }

        public override string ToString()
        {
            return "Account No: " + _accNo + " Account Name: " + _accName + " Balance: " + _balance;
        }

        public abstract void Withdraw(double amount);

    }
}
