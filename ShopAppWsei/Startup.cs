using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShopAppWsei.Middlewares;
using ShopAppWsei.Models;
using ShopAppWsei.SignalRChat.Hubs;


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
            services.AddSignalR();
            services.AddSwaggerGen();
            services.AddControllers();
            services.AddTransient<IProductRepository, EFProductRepository>();
            //services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration["Data:ComputerStoreProducts:ConnectionString"]));
            services.AddDbContext<AppDbContext>(options => options.UseNpgsql(
                Configuration.GetConnectionString("DefaultConnection")
                )
             );
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            app.UseAuthentication();
            app.UseDeveloperExceptionPage(); // informacje szczegółowe o błędach
            app.UseStatusCodePages(); // Wyświetla strony ze statusem błędu
            app.UseStaticFiles(); // obsługa treści statycznych css, images, js
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //app.UseMiddleware<ElapsedTimeMiddleware>();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = "api";
            });

            app.UseRouting();
            app.UseAuthorization();
            
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
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapHub<ChatHub>("/chathub");
            });

            SeedData.EnsurePopulated(app);
        }
    }
}
