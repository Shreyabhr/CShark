using System;

namespace AccountApp.Model
{
    public delegate void AccountHandler(Account acc);
    public class Account
    {
        private int _accNo;
        private String _accName;
        private double _balance;
        private double _minBalance = 500;
        public event AccountHandler BalanceChanged;

        public Account(int accNo, String accName)
        {
            _accNo = accNo;
            _accName = accName;
            //BalanceChanged += new AccountHandler(this);
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
            if(BalanceChanged != null)
            {
                BalanceChanged(this);
            }
        }

    }
}
