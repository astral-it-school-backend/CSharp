using System;
using System.Linq;
using IT_School.CSharp.OOP.Model;

namespace IT_School.CSharp.OOP
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Car firstCar = new Car(4000, 220, 3, "vvv");
            var cc = new Car("dddd");
            Car.SayCar();
            Car.SingleTon = "dddd";
//            Human vlad = new Human(74, 175, "Влад");
//            Human ivan = new Human(74, 175, "Иван");
//            Human dima = new Human(74, 240, "Дима");
//            Human alex = new Human(74, 175, "Алексей");
//            
//            
//            firstCar.AddPassanger(vlad);
//            firstCar.AddPassanger(ivan);
//            firstCar.AddPassanger(dima);
//            firstCar.AddPassanger(alex);
            
            firstCar.Move("влево");
            var firstCarAsTransport = (Transport)firstCar;
            firstCarAsTransport.Move("направо");

            var rnd = new Random();
            var result = rnd.Next(1, 14);
            Console.WriteLine($"Hello {result}!");


            Console.ReadKey();
        }
    }
}

