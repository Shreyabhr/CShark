using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RectangleEncapsulationApp.Model;

namespace RectangleEncapsulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(100, 200);
            Console.WriteLine(rect.GetHeight());
            rect.SetBorderStyle(BorderStyle.DOTTED);
            Console.WriteLine(rect.GetBorder());
        }
    }
}
