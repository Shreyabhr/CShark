using System;

namespace AccountApp.Model
{
    class Account
    {
        private int _accNo;
        private String _accName;
        private double _balance;
        private double _minBalance = 500;
        private static int _headCount = 0;

        public Account(int accNo, String accName)
        {
            _accNo = accNo;
            _accName = accName;
            _headCount++;
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
            set
            {
                _balance = value;
            }
        }

        public static int HeadCount
        {
            get
            {
                return _headCount;
            }
        }

        public void Withdraw(double amount)
        {
            if(_balance - amount < _minBalance)
            {
                throw new Exception("Balance Not Sufficient");
            }
            _balance -= amount;
        }

        public void Deposite(double amount)
        {
            _balance += amount;
        }

        public override string ToString()
        {
            return "Account No: " + this._accNo + " Account Name: " + this._accName + " Balance: " + this._balance;
        }

    }
}
