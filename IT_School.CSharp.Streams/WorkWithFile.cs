using System;
using System.IO;

namespace IT_School.CSharp.Streams
{
    public class WorkWithFile
    {
        private string _basePath;

        public WorkWithFile()
        {
            _basePath = Path.Combine(Directory.GetCurrentDirectory(), "storage");
            Directory.CreateDirectory(_basePath);
        }
        
        public void WriteFile(string filename, string text)
        {
            var file = File.Open(Path.Combine(_basePath, filename), FileMode.OpenOrCreate);
            using var writer = new StreamWriter(file);
            writer.Write(text);
        }

        public string ReadFile(string filename)
        {
            var file = File.OpenRead(Path.Combine(_basePath, filename));
            using var reader = new StreamReader(file);
            return reader.ReadToEnd();
        }
    }
}