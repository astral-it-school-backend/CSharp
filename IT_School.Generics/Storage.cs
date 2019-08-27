using IT_School.Generics.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace IT_School.Generics
{
    public class Storage<T> where T : FileModel
    {
        private List<T> _files;

        public Storage()
        {
            _files = new List<T>();
        }
        public void Add(string filepath)
        {

        }
    }

}
