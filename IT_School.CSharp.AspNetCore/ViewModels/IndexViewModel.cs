using System.Collections.Generic;
using IT_School.CSharp.EFCore.Entities;

namespace IT_School.CSharp.AspNetCore.ViewModels
{
    public class IndexViewModel
    {
        public List<Person> Persons { get; set; }

        public IndexViewModel(List<Person> persons)
        {
            Persons = persons;
        }
    }
}