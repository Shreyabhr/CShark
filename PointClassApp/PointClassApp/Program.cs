using System;

namespace PointApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(0, 0);
            Console.WriteLine("Before updating values from class");
            p.PrintDetails(p);
            p.Update(p);
            Console.WriteLine("After updating values from class");
            p.PrintDetails(p);

            PointStructure point = new PointStructure(0,0);
            Console.WriteLine("Before updating values from structure");
            point.PrintDetails(point);
            point.Update(point);
            Console.WriteLine("After updating values from structure");
            point.PrintDetails(point);
        }
    }
}
