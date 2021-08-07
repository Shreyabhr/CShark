using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomAnnotationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DoReflection(typeof(CustomAnnotationFoo));
        }

        private static void DoReflection(Type type)
        {
            MethodInfo[] methods = type.GetMethods();
            foreach(MethodInfo method in methods)
            {
                if (method.CustomAttributes.ToArray().Length > 0)
                {
                    NeedToRefactorAttribute attribute = method.GetCustomAttribute<NeedToRefactorAttribute>();
                    if(attribute != null)
                    {
                        Console.WriteLine(method.Name);
                    }
                }
                
            }
        }
    }
}
