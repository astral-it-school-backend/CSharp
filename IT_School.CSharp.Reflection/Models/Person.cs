using System.ComponentModel.DataAnnotations;

namespace IT_School.CSharp.Reflection.Models
{
    public class Person
    {
        [Required]
        [IsKolya]
        public string Name;
        
        [Required]
        [MaxLength(10)]
        public string Surname;

        public string Patronymic;

        [Required]
        [Positive]
        public int Age;
    }
}