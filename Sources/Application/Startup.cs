using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lamar;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DataAccess.DbContexts;
using WebApplication1.Settings.Models;

namespace WebApplication1
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }

        public Startup(Microsoft.Extensions.Hosting.IHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", false, true);

            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            builder
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", true, false);

            if (environment == "Development")
            {
                builder.AddUserSecrets<AppSettings>();
            }

            Configuration = builder.Build();
        }

        public void ConfigureContainer(ServiceRegistry services)
        {
            services.Scan(
                scanner =>
                {
                    scanner.AssemblyContainingType<Startup>();
                    scanner.WithDefaultConventions();
                });

            services.Configure<AppSettings>(Configuration.GetSection(AppSettings.SectionKey));
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddRazorPages();
        }

            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();


            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
