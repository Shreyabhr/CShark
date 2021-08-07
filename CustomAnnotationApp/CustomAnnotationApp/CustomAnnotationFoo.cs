using System;

namespace CustomAnnotationApp
{
    class CustomAnnotationFoo
    {
        [NeedToRefactor]
        public void m1()
        {
            Console.WriteLine("method m1");
        }

        [NeedToRefactor]
        public void m2()
        {
            Console.WriteLine("method m2");
        }

        public void m3()
        {
            Console.WriteLine("method m3");
        }
    }
}
