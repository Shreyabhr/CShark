using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcLib
{
    public class Calculator
    {
        public bool CheckEven(int no)
        {
            return (no % 2 == 0);
        }

        public bool CheckPrime(int no)
        {
            for(int i = 2; i < no; i++)
            {
                if(no % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
