using System;

namespace IT_School.CSharp.OOP.Model
{
    public class Transport
    {
        protected string _name;
        
        public virtual void Move(string direction)
        {
            Console.WriteLine($"Двигаемся {direction}");
        }

//        public Transport(string name)
//        {
//            _name = name;
//        }
    }
}