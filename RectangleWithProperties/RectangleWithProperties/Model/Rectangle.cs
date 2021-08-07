namespace RectangleEncapsulationApp.Model
{
    class Rectangle
    {
        private int _height;
        private int _width;
        BorderStyle _border;

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if(value > 0)
                {
                    _height = value;
                    return;
                }
                _height = 1;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if(value > 0)
                {
                    _width = value;
                    return;
                }
                _width = 1;
            }
        }

        public BorderStyle Border
        {
            get
            {
                return _border;
            }
            set
            {
                _border = value;
            }
        }
        
        public int CalculateArea()
        {
            return _width * _height;
        }
    }
}
