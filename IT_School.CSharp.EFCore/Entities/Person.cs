using System;
using System.ComponentModel.DataAnnotations;

namespace IT_School.CSharp.EFCore.Entities
{
    public class Person
    {
        public Guid Id { get; set; }

        public Guid AddressId { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }

        public virtual Address Address { get; set; }

        public Person(string name, string surname, string patronymic)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
        }

        public Person()
        {
            
        }
    }
}