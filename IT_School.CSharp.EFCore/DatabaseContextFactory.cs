using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace IT_School.CSharp.EFCore
{
    public class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            optionsBuilder.UseNpgsql("User ID=postgres;Password=123456;host=localhost;Database=it_school;",
                a => a.MigrationsAssembly("IT_School.CSharp.EFCore"));

            return new DatabaseContext(optionsBuilder.Options);
        }
    }
}