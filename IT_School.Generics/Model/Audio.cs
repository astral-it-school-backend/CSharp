using System;
using System.Collections.Generic;
using System.Text;

namespace IT_School.Generics.Model
{
    class Audio : FileModel
    {
        public Audio(string fileName) : base(fileName)
        {
            _extentions = new string[] { "mp3", "flac", "mp4" };
        }
        
    }
}
   
    
