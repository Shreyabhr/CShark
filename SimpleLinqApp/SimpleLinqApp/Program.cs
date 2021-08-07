using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleLinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> names = args;
            var longNames = names.Where(n => n.Length > 5);

            var resut = longNames.ToArray();

            var ascendingOrder = NamesInAscendingOrder(names);
            Console.WriteLine("names in ascending order");
            foreach (var order in ascendingOrder)
            {
                Console.WriteLine(order);
            }

            var namesWithVowels = NamesWithVowel(names);
            Console.WriteLine("Names with vowels");
            foreach (var order in namesWithVowels)
            {
                Console.WriteLine(order);
            }

            var firstFiveCharacters = First5Characters(names);
            Console.WriteLine("first five characters");
            foreach (var order in firstFiveCharacters)
            {
                Console.WriteLine(order);
            }
        }

        private static IEnumerable<string> First5Characters(IEnumerable<string> name)
        {
            return name.Select(n => {
                if (n.Length < 5)
                {
                    return n;
                }
                return n.Substring(0, 5);
            });
        }

        private static IEnumerable<string> NamesWithVowel(IEnumerable<string> name)
        {
            return name.Where(n =>
            {
                string lowerCaseName = n.ToLower();
                return lowerCaseName.Contains('a') || lowerCaseName.Contains('e') || lowerCaseName.Contains('i') || lowerCaseName.Contains('o') || lowerCaseName.Contains('u');

            });
        }

        private static IOrderedEnumerable<string> NamesInAscendingOrder(IEnumerable<string> name)
        {
            return name.OrderBy(n => n);
        }
    }
}
