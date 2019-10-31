using System;
using System.Linq;
using IT_School.CSharp.EFCore.Serivces;
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
                    options.UseNpgsql("User ID=postgres;Password=123456;host=localhost;Database=it_school;",
                        a => a.MigrationsAssembly("IT_School.CSharp.EFCore"));
                });
            serviceCollection.AddScoped<FlatService>();
            
            var provider = serviceCollection.BuildServiceProvider();

            try
            {
                using (var scope = provider.CreateScope())
                {
                    var service = provider.GetService<FlatService>();
                    service.ShowRoomers(Guid.Parse("21b1e492-278e-4b57-80ed-805cced59fdf")).Wait();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}