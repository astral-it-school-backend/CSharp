using System;
using System.Collections.Generic;
using System.Text;

namespace IT_School.Generics.Model
{
    public class TextModel : FileModel
    {
        
        public TextModel(string fileName) : base (fileName)
        {
            _extentions = new string[] { "txt", "doc", "docx", "xml" };
        }
       

    }
}
