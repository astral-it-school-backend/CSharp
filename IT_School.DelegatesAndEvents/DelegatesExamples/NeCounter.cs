using System;

namespace IT_School.DelegatesAndEvents
{
    public class NeCounter
    {
        public void Run(int ticks)
        {
            for (int i = ticks; i >= 0; i--)
            {
                Console.WriteLine("Пять");
            }
        }

        public static void RunStatic(int ticks)
        {
            for (int i = ticks; i >= 0; i--)
            {
                Console.WriteLine("Пять");
            }
        }

        public string Return(int ticks)
        {
            for (int i = ticks; i >= 0; i--)
            {
                Console.WriteLine("Пять");
            }

            return "Пять";
        }

        public class AAA
        {

        }
    }


}
