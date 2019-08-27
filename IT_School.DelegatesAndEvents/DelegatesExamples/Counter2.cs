using System;

namespace IT_School.DelegatesAndEvents
{
    public class Counter2
    {
        public void Run(int ticks)
        {
            for (int i = ticks; i >= 0; i--)
            {
                Console.WriteLine($"-Тик №{i}");
            }
        }
    }


}
