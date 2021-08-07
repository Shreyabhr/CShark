using System;

namespace RectangleEncapsulationApp.Model
{
    class Rectangle
    {
        int _height;
        int _width;
        BorderStyle _border;
        public Rectangle(int height, int width)
        {
            if (height < 0)
            {
                _height = 1;
            }
            _height = height;
            if (width < 0)
            {
                _width = 1;
            }
            _width = width;
            
        }

        public Rectangle(int height, int width , BorderStyle border)
        {
            if (height < 0)
            {
                _height = 1;
            }
            if (width < 0)
            {
                _width = 1;
            }
            _width = width;
            _border = border;
        }

        public int GetHeight()
        {
            return _height;
        }
        public int GetWeight()
        {
            return _width;
        }

        public BorderStyle GetBorder()
        {
            return _border;
        }

        public int CalculateArea()
        {
            return _width * _height;
        }

        public void SetBorderStyle(BorderStyle border)
        {
            _border = border;
        }
    }
}
