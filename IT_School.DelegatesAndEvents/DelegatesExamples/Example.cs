using System;

namespace IT_School.DelegatesAndEvents
{
    public class Example
    {
        public delegate void ExampleDelegate(int count);

        public delegate string NotVoidExampleDelegate(int count);

        public void Start(ExampleDelegate d)
        {
            Console.WriteLine("Сейчас произойдет что-то связанное с цифрой 5");
            d.Invoke(5);
        }

        public string StartNotVoid(NotVoidExampleDelegate d)
        {
            Console.WriteLine("Сейчас произойдет что-то связанное с цифрой 5 и что-то вернется");

            return d.Invoke(5);
        }

    }


}
