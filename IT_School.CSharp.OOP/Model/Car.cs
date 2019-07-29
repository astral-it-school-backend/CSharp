using System;

namespace IT_School.CSharp.OOP.Model
{
    public class Car
    {
        private int _maxMass;
        private int _maxHeight;
        private Human[] _passangers;
        private int _countOfPassangers;
        
        public Car(){}

        public Car(int maxMass, int maxHeight, int maxPassangers)
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
            if (newHuman.GetMass() < _maxMass)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Максимальная масса превышена");
                return false;
            } 
        }
        
        
        
    }
}