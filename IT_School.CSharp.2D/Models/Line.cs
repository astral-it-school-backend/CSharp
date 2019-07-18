using System;

namespace IT_School.CSharp._2D.Models
{
    public struct Line
    {
        public Point StartPoint;
        public Point EndPoint;

        
        
        public double GetDistance(Point startPoint,Point endPoint)
        {
            double diffX = (endPoint.GetX() - startPoint.GetX());
            double diffY = (endPoint.GetY() - startPoint.GetY());
            
            return Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));
        }
    }
}