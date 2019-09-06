using System;

namespace IT_School.CSharp.OOP.Model
{
    public class Car : Transport
    {
        private int _maxMass;
        private int _maxHeight;
        private Human[] _passangers;
        private int _countOfPassangers;

        public static void SayCar()
        {
            Console.WriteLine("Car");
        }

        public static string SingleTon;

        public Car(string name)
        {
            if (name.Length > 100)
            {
                name = name.Substring(0, 100);
            }
            _name = name;
        }

        public Car(int maxMass, int maxHeight, int maxPassangers, string name) : this(name)
        {
            _maxMass = maxMass;
            _maxHeight = maxHeight;
            _countOfPassangers = 0;
            _passangers = new Human[maxPassangers];
        }

        public void AddPassanger(Human newHuman)
        {
            if (EnthialPassangers() && EnthialHeight(newHuman) && EnthialMass(newHuman))
            {
                _passangers[_countOfPassangers] = newHuman;
                _countOfPassangers++;
                Console.WriteLine($"Пассажир {newHuman.GetName()} добавлен)");
            }
            
        }


        private bool EnthialPassangers()
        {
            if (_countOfPassangers < _passangers.Length)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Все места забиты(");
                return false;
            }
        }
        private bool EnthialHeight(Human newHuman)
            {
                if (newHuman.GetHeight() < _maxHeight)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Максимальный рост превышена");
                    return false;
                }
            }

        private bool EnthialMass(Human newHuman)
        {
            if (newHuman.Mass < _maxMass)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Максимальная масса превышена");
                return false;
            } 
            
        }
        
        public new void Move(string direction)
        {
            Console.WriteLine($"Едем {direction}");
        }
        
        public void MoveBase(string direction)
        {
            base.Move(direction);
        }
        
    }
}