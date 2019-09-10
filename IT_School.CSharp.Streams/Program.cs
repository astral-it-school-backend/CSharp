using System;
using System.Linq;
using IT_School.CSharp.Streams;

namespace IT_School.CSharp.Streams
{
    class Program
    {
        static void Main(string[] args)
        {
//            var workWithFile = new WorkWithFile();
//            
//            
//            workWithFile.WriteFile("test.txt","Какой то текст");



            //           Console.WriteLine(workWithFile.ReadFile("test.txt"));


            using (TempFile tempFile = new TempFile())
            {
                tempFile.Write("Мы писали, мы писали, наши пальчики устали.");
                Console.WriteLine(tempFile.Read());
            }

            Console.ReadKey();
        }
    }
}