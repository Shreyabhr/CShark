using System;

namespace WelcomeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello from a console application");
            //For Loop
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //While loop
            int num = 5;
            Console.WriteLine("In while loop");
            while (num < 10)
            {               
                Console.WriteLine(num);
                num++;
            }

            //Foreach Loop
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Foreach loop");
            foreach (int number in array)
            {
                Console.WriteLine(number);
            }

            //String array
            string[] stringArray = new string[3] { "elementa", "elementb", "elementc" };
            Console.WriteLine("String Array");
            Console.WriteLine(stringArray[0]);
            Console.WriteLine(stringArray[1]);
            Console.WriteLine(stringArray[2]);

            //Character array
            char[] charArray = new char[3] { 'A', 'B', 'C' };
            Console.WriteLine("Character Array");
            foreach (Char element in charArray)
            {
                Console.WriteLine(element);
            }

        }
    }
}
