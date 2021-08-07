using System;

namespace CalcDelegateApp
{
    class Program
    {
        private delegate void DMathOperation(int a, int b);
        static void Main(string[] args)
        {
            DMathOperation op;
            op = Add;
            op += Subtract;
            op += Divison;
            op += Modulus;
            op(10, 2);
        }

        private static void Modulus(int a, int b)
        {
            Console.WriteLine(a % b);
        }

        private static void Divison(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        private static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        private static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
