using System;
using System.Collections.Generic;

namespace IT_School.CSharp.EFCore.Entities
{
    public class Address
    {
        public Guid Id { get; set; }

        public string Street { get; set; }
        
        public string House { get; set; }
        
        public string Flat { get; set; }

        public virtual ICollection<Person> Roomers { get; set; }

        public Address(string street, string house, string flat)
        {
            Id = Guid.NewGuid();
            Street = street;
            House = house;
            Flat = flat;
        }

        public Address()
        {
            
        }
    }
}