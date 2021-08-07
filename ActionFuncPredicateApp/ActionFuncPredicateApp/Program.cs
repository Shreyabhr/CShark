using System;

namespace ActionFuncPredicateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> CheckBigName = IsaBigName;
            Console.WriteLine(CheckBigName("shreya bhoir"));

            Predicate<int> isEvenNumber = delegate (int no){
                return no % 2 == 0;
            };
            Console.WriteLine(isEvenNumber(4));

            Predicate<int> isPrimeNumber = no =>
            {
                for (int i = 2; i <= no / 2; i++)
                {
                    if (no % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            };
            Console.WriteLine(isPrimeNumber(3));

            Func<int, long, double> add = AddNumber;
            Console.WriteLine(add(12, 12789393));

            Func<int, long, double> MultiplyNumbers = delegate (int num1, long num2)
            {
                return Convert.ToDouble(num1 * num2);
            };
            Console.WriteLine(MultiplyNumbers(31, 37927389));

            Func<int, long, double> SubtractNum = (num1, num2) =>
            {
                return Convert.ToDouble(num1 - num2);

            };
            Console.WriteLine(SubtractNum(45, 237927938));

            Action<int> GetIntegerNumber = PrintNumber;
            GetIntegerNumber(45);

            Action<double> GetDoubleNumber = delegate (double num)
            {
                Console.WriteLine("Number is: " + num);
            };
            GetDoubleNumber(893.883);

            Action<float> GetFloatNumber = (no) => Console.WriteLine("Number is: " + no);
            GetFloatNumber(67);
        }

        private static void PrintNumber(int num)
        {
            Console.WriteLine("Number is: " + num);
        }

        private static double AddNumber(int num1, long num2)
        {
            return Convert.ToDouble(num1 + num2);
        }

        private static bool IsaBigName(string name)
        {
            return name.Length >= 8;
        }
    }
}
