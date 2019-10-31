using IT_School.CSharp.EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace IT_School.CSharp.EFCore
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public DatabaseContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Person>().HasKey(a => a.Id);
            modelBuilder.Entity<Person>()
                .HasOne(a => a.Address)
                .WithMany(a => a.Roomers)
                .HasForeignKey(a => a.AddressId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}