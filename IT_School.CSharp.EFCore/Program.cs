using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IT_School.CSharp.EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<DatabaseContext>(options =>
            {
                options.UseNpgsql("User ID=postgres;Password=123456;host=localhost;Database=it_school;");
            });
            
            var provider = serviceCollection.BuildServiceProvider();

            using (var scope = provider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetService<DatabaseContext>();
                
                var person = dbContext.Persons.First();
            }

            Console.ReadKey();
        }
    }
}