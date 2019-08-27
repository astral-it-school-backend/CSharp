using System;

namespace IT_School.DelegatesAndEvents
{
    public class ExampleActionAndFunc
    {
        public void Start(Action<int> d)
        {
            Console.WriteLine("Сейчас произойдет что-то связанное с цифрой 5");
            d.Invoke(5);
        }

        public void Start(Action<int, string> d)
        {
            Console.WriteLine("Сейчас произойдет что-то связанное с цифрой 5");
            d.Invoke(5, "hello");
        }

        public string StartNotVoid(Func<int, string> d)
        {
            Console.WriteLine("Сейчас произойдет что-то связанное с цифрой 5 и что-то вернется");

            return d.Invoke(5);
        }
    }


}
