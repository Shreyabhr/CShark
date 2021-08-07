using System;
using RectangleEncapsulationApp.Model;

namespace RectangleWithProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Height = -1;
            Console.WriteLine(rect.Height);
            rect.Width = 100;
            Console.WriteLine(rect.CalculateArea());
            rect.Border = BorderStyle.SOLID;
        }
    }
}
