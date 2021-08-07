using System;
using System.Reflection;
using AccountApp.Model;

namespace AccountReflectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DoReflection(typeof(Object));      
        }

        private static void DoReflection(Type reflectionClass)
        {
            int get = 0, set = 0;
            Console.WriteLine(reflectionClass.Name);
            MethodInfo[] getMethods = reflectionClass.GetMethods();
            foreach (MemberInfo method in getMethods)
            {
                Console.WriteLine(method);
                if (method.Name.StartsWith("g"))
                {
                    get += 1;
                    continue;
                }
                if (method.Name.StartsWith("s"))
                {
                    set += 1;
                }
            }
            Console.WriteLine("No of methods: " + getMethods.Length);
            Console.WriteLine("No of Getter: " + get);
            Console.WriteLine("No of Setters: " +set);
        }
    }

}
