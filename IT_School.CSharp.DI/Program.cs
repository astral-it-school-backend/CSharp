using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace IT_School.CSharp.DI
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
         
            serviceCollection.AddSingleton<Single>();

            var provider = serviceCollection.BuildServiceProvider();

            var single = provider.GetService<Single>();
            Console.WriteLine(single.S);

            Console.ReadKey();
        }
    }

    public class Single
    {
        public string S => "I Single";
    }
}