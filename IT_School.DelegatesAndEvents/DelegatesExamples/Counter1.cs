using System;

namespace IT_School.DelegatesAndEvents
{
    public class Counter1
    {
        public void Run(int ticks)
        {
            for (int i = 0; i < ticks; i++)
            {
                Console.WriteLine($"Тик №{i}");
            }
        }
    }


}
