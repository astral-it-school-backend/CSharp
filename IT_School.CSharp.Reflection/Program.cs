using System;
using System.Linq;
using System.Reflection;
using IT_School.CSharp.Reflection.Models;

namespace IT_School.CSharp.Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Example1();

            var person = new Person
            {
                Name = "ivan",
                Surname = "kkk",
                Age = 1
            };
            
            Console.WriteLine(Validator.Validate(person));

            Console.ReadKey();
        }

        private static void Example1()
        {
            var printer = new Printer();

            var type = typeof(Printer);

            var method = type.GetMethod("WriteLine");
            
            if (method != null)
                method.Invoke(printer, new object[] {"Hello World!", 1});
        }
        
        private static void Example2()
        {
            var type = typeof(Console);
            var method = type.GetMethods()
                .First(a => a.Name == "WriteLine" &&
                            a.GetParameters().Any(p =>
                                p.ParameterType == typeof(string)));

            if (method != null)
                method.Invoke(null, new object[] {"Hello World!"});
        }
    }
    
    

    public class Printer
    {
        public void WriteLine(string str, int n)
        {
            Console.WriteLine($"{str}№{n}");
        }
    }
}