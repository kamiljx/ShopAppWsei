using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShopAppWsei.Models;


namespace ShopAppWsei
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddTransient<IProductRepository, EFProductRepository>();
            //services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration["Data:ComputerStoreProducts:ConnectionString"]));
            services.AddDbContext<AppDbContext>(options => options.UseNpgsql(
                Configuration.GetConnectionString("DefaultConnection")
                )
             );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage(); // informacje szczegółowe o błędach
            app.UseStatusCodePages(); // Wyświetla strony ze statusem błędu
            app.UseStaticFiles(); // obsługa treści statycznych css, images, js
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }



            app.UseRouting();

            app.UseEndpoints(routes =>
            {
                routes.MapControllerRoute(
                     name: "default",
                    pattern: "{controller=Product}/{action=List}/{id?}");

                routes.MapControllerRoute(
                        name: "Sorted product",
                        pattern: "Product/{category}",
                        defaults: new
                        {
                            controller = "Product",
                            action = "List"
                        });

                routes.MapControllerRoute(
                     name: "defaultAdmin",
                    pattern: "{controller=Admin}/{action=Index}");

                routes.MapControllerRoute(
                     name: "Admin panel",
                    pattern: "{controller=Admin}/{action=Index}");

                routes.MapControllerRoute(
                     name: "Admin panel edit",
                    pattern: "{controller=Admin}/{action=Edit}/{id?}");

                routes.MapControllerRoute(
                     name: "Admin panel Delete",
                    pattern: "{controller=Admin}/{action=Delete}/{id?}");
            });
        SeedData.EnsurePopulated(app);
        }
    }
}
