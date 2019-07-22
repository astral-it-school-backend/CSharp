using System;
using IT_School.CSharp._2D.Models;

namespace IT_School.CSharp._2D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(0,0);
            Point p2 = new Point(0,0);
            Line line = new Line(p1, p2);
            
            
            Console.WriteLine("Выбирите действие: " +
                              "f1 - задать координаты; f2 - задать координатыx; " +
                              "f3 - смещение точки P2;; f4 - вычислениям растояния между точками");
            var action = Console.ReadKey().Key;
            //var f1 = ConsoleKey.F1;
            switch (action)
            {
                case ConsoleKey.D1:
                {
                    Console.WriteLine("Введите смещение по оси Х");

                    double sh_x = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите смещение по оси Y");

                    double sh_y = Double.Parse(Console.ReadLine());

                    line.StartPoint.Shift(sh_x, sh_y);

                    Console.WriteLine(line.ToString());

                    break;
                }

                case ConsoleKey.D2:
                {
                    Console.WriteLine(line.ToString());
                    break;
                }
                
                case ConsoleKey.D3:
                {
                    
                    Console.WriteLine(line.GetDistance().ToString());
                    break;
                }
            }

            Console.ReadKey();

        }
    }
}