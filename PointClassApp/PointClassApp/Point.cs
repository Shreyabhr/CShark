using System;

namespace PointApp
{
    class Point
    {
        private int _x;
        private int _y;
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public void Update(Point p)
        {
            p.X = 10;
            p.Y = 11;
        }

        public void PrintDetails(Point p)
        {
            Console.WriteLine(p.X+ ":" +p.Y);
        }
    }
}
