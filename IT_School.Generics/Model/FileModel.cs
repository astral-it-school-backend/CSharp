using System;
using System.Collections.Generic;
using System.Text;

namespace IT_School.Generics.Model
{
    public abstract class FileModel

    {
        public string FileName { get; }
        public FileModel(string fileName)
        

        {
            FileName = fileName;
        }
        public  bool CheckType(string fileName)
        {
            foreach (var item in _extentions)
            {
                if (fileName.Contains(item))
                {
                    return true;
                }

            }
            return false;
        }
        protected string[] _extentions;
    }

}
