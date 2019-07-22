using System;

namespace IT_School.CSharp._2D.Models
{
    public struct Line
    {
        public Point StartPoint;
        public Point EndPoint;

        
        
        public double GetDistance()
        {
            double diffX = (EndPoint.GetX() - StartPoint.GetX());
            double diffY = (EndPoint.GetY() - StartPoint.GetY());
            
            return Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));
        }

        public Line(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public override string ToString()
        {
            return $"X1: {StartPoint.GetX()} Y1: {StartPoint.GetY()}\n X2: {EndPoint.GetX()} Y2: {EndPoint.GetY()}";
        }
    }
}