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

            serviceCollection.AddSingleton<ISingle, Single>();
            serviceCollection.AddSingleton<ISingle, Single2>();
            serviceCollection.AddTransient<Transient>();
            serviceCollection.AddTransient<SubTransient>();
            serviceCollection.AddTransient<SubSubTransient>();
            serviceCollection.AddScoped<Scoped>();

            var provider = serviceCollection.BuildServiceProvider();

            for (int i = 0; i < 3; i++)
            {
                var single = provider.GetRequiredService<ISingle>();

                Console.WriteLine(single.S);
            }

            for (int i = 0; i < 3; i++)
            {
                var transient = provider.GetService<Transient>();

                Console.WriteLine(transient.S);
            }

            using (var scope1 = provider.CreateScope())
            {
                for (int i = 0; i < 3; i++)
                {
                    var scoped = scope1.ServiceProvider.GetService<Scoped>();
                    Console.WriteLine(scoped.S);
                }
            }

            using (var scope2 = provider.CreateScope())
            {
                for (int i = 0; i < 3; i++)
                {
                    var scoped = scope2.ServiceProvider.GetService<Scoped>();
                    Console.WriteLine(scoped.S);
                }
            }

            Console.ReadKey();
        }
    }

    public class Single : ISingle
    {
        private int _count;
        private Scoped _scoped;
        private Transient _transient;

        public string S
        {
            get
            {
                _count++;
                return $"I Single {_count} {_scoped.S} {_transient.S}";
            }
        }

        public Single(Scoped scoped, Transient transient)
        {
            _scoped = scoped;
            _transient = transient;
            _count = 0;
        }
    }

    public class Single2 : ISingle
    {
        public string S => "SSS";
    }

    public interface ISingle
    {
        string S { get; }
    }
    
    public class Transient
    {
        private int _count;
        private SubTransient _subTransient;

        public string S
        {
            get
            {
                _count++;
                return $"I Transient {_count} and {_subTransient.S}";
            }
        }

        public Transient(SubTransient subTransient)
        {
            _subTransient = subTransient;
            _count = 0;
        }
    }
    
    public class Scoped
    {
        private int _count;

        public string S
        {
            get
            {
                _count++;
                return $"I Scoped {_count}";
            }
        }

        public Scoped()
        {
            _count = 0;
        }
    }
    
    public class SubTransient
    {
        private int _count;
        private SubSubTransient _subSubTransient;

        public string S
        {
            get
            {
                _count++;
                return $"I SubTransient {_count} {_subSubTransient.S}";
            }
        }

        public SubTransient(SubSubTransient subSubTransient)
        {
            _subSubTransient = subSubTransient;
            _count = 0;
        }
    }
    
    public class SubSubTransient
    {
        private int _count;

        public string S
        {
            get
            {
                _count++;
                return $"I SubSubTransient {_count}";
            }
        }

        public SubSubTransient()
        {
            _count = 0;
        }
    }
}