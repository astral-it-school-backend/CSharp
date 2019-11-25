using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using IT_School.CSharp.AspNetCore.Filters;
using IT_School.CSharp.AspNetCore.Options;
using IT_School.CSharp.AspNetCore.Services;
using IT_School.CSharp.EFCore;
using IT_School.CSharp.EFCore.Serivces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

namespace IT_School.CSharp.AspNetCore
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddControllers(options => options.Filters.Add<ExceptionFilter>())
                .AddViewComponentsAsServices()
                .AddViewLocalization()
                
                //.AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.IgnoreNullValues = true;
                });
            services.AddLogging();

            services.AddScoped<ExceptionFilter>();
            
            services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseNpgsql("User ID=postgres;Password=123456;host=localhost;Database=it_school;",
                    a => a.MigrationsAssembly("IT_School.CSharp.EFCore"));
            });
            
            //services
            services.AddScoped<FlatService>();
            services.AddScoped<PinterestClient>();
            
            //options
            var options = new ApplicationOptions(_configuration["RemoteApi:PinterstApiKey"]);
            services.AddSingleton(options);

            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = "api/help";
            });
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}