using System;
using System.IO;
using System.Text;

namespace IT_School.CSharp.Streams
{
    public class TempFile : IDisposable
    {
        private FileStream _fileStream;

        public TempFile()
        {
            _fileStream = File.Create("temp.txt");
            //_fileStream = File.Open(Path.Combine(Directory.GetCurrentDirectory(), "storage", "test.txt"),FileMode.Open);
        }

        public string Read()
        {
            byte[] buffer = new byte[_fileStream.Length];
            int i = 0;
            int b;
            while (( b =_fileStream.ReadByte())!=-1)
            {
                buffer[i] = (byte) b;
                i++;
            }
            
            _fileStream.Seek(0,SeekOrigin.Begin);

            return  Encoding.UTF8.GetString(buffer);
        }

        public void Write(string text)
        {
            BinaryWriter bWriter = new BinaryWriter(_fileStream, Encoding.UTF8);
            bWriter.Write(text);
            _fileStream.Seek(0,SeekOrigin.Begin);
        }
        
        
        public void Dispose()
        {
            _fileStream.Dispose();
            _fileStream.Close();
            File.Delete("temp.txt");
        }
    }
}