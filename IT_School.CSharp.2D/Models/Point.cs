using System;

namespace IT_School.CSharp._2D.Models
{
    public struct Point
    {
        private double _x;
        private double _y;

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }
        
        public void Shift(double x, double y)
        {
            if (x == 0 || y == 0)
            {
                throw new InvalidOperationException("Noooooooo!!!");
            }
            _x += x;
            _y += y;
        }
        
        public double GetX()
        {
            return _x;
        }
        
        public double GetY()
        {
            return _y;
        }
    }
}