using System;

namespace IT_School.CSharp.OOP.Model
{
    public class Human
    {
        public int Mass { get; private set; }

        private int _height;
        private string _name;
        
        
        
        public Human(){}

        public Human(int mass, int height, string name)
        {
            Mass = mass;
            _height = height;
            _name = name;
            Console.WriteLine(Car.SingleTon);
        }
        

        public int GetHeight()
        {
            Mass = 10;
            return _height;
        }

        public string GetName()
        {
            return _name;
        }
    }
}