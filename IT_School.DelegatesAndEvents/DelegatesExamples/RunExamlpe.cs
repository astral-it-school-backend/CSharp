using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IT_School.DelegatesAndEvents.DelegatesExamples
{
    public class RunExamlpe
    {
        public static void Run()
        {
            #region Example
            var example = new Example();

            if (Console.ReadKey().Key == ConsoleKey.OemMinus)
            {
                var counter = new Counter2();
                example.Start(counter.Run);
            }
            else if (Console.ReadKey().Key == ConsoleKey.D5)
            {
                var counter = new NeCounter();
                example.Start(counter.Run);
                Console.WriteLine(example.StartNotVoid(counter.Return));
            }
            else
            {
                var counter = new Counter1();
                example.Start(counter.Run);
            }

            NeCounter.AAA aaa = new NeCounter.AAA();

            //Example.ExampleDelegate delegateReference = NeCounter.RunStatic;

            //example.Start(delegateReference);

            #endregion

            #region Example1

            var neCounter = new NeCounter();

            var example2 = new ExampleActionAndFunc();

            Action<int, string> action1 = (count, str) =>
            {
                Console.WriteLine(str);

                for (int i = count; i >= 0; i--)
                {
                    Console.WriteLine("Пять");
                }
            };

            example2.Start(action1);

            example2.Start(a => Console.WriteLine(a));
            #endregion

            var list = new List<string>();
            list.Add("adasd");
            var filtered = list.Where((str, index) => str[0] == 'a');
            //var filtered = list.Where((str, index) => 
            //{
            //    Console.WriteLine(index);
            //    return str[0] == 'a';
            //});
        }
    }
}
