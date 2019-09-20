using System;
using System.IO;
using System.Net.Http;

namespace IT_School.CSharp.HTTP
{
    public class Example1
    {
        public static void Start()
        {
            Console.WriteLine("Hello World!");
            using (HttpClient http = new HttpClient())
            using (var response = http.GetAsync("https://www.google.com").Result)
            using ( var fileStream = File.Create("Http.html"))
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                var str = response.Content.ReadAsStringAsync().Result;
                writer.Write(str);
            }
            
            using (var fileStream = File.Open("Http.html", FileMode.Open))
            using (var read = new StreamReader(fileStream))
            {
                Console.WriteLine(read.ReadToEnd());
            }

        }
    }
}