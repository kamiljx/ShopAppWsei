using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAppWsei.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            var context = app.ApplicationServices
                .GetRequiredService<AppDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Dysk twardy SSD",
                        Description = "Dysk do przechowywania danych",
                        Category = "Dyski",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Mysz",
                        Description = "Myszka komputerowa typu gaming",
                        Category = "Gaming",
                        Price = 48.95m
                    },
                    new Product
                    {
                        Name = "Klawiatura",
                        Description = "Klawiatura komputerowa typu gaming",
                        Category = "Gaming",
                        Price = 19.50m
                    },
                    new Product
                    {
                        Name = "Monitor 24",
                        Description = "Urządzenie do wyświetlania obrazu z 3 portami USB-C",
                        Category = "Monitory",
                        Price = 1450
                    },
                    new Product
                    {
                        Name = "Touchpad",
                        Description = "Bezprzewodowy touchpad dla urządzeń Windows",
                        Category = "Peryferia",
                        Price = 130
                    },
                    new Product
                    {
                        Name = "Monitor 27",
                        Description = "Monitor dobrej jakości, 1 wejście HDMI",
                        Category = "Monitory",
                        Price = 16
                    },
                    new Product
                    {
                        Name = "Fotel XL BOSS",
                        Description = "Fotel gamingowy dla graczy z pasją",
                        Category = "Gaming",
                        Price = 29.95m
                    },
                    new Product
                    {
                        Name = "Klawiatura LG",
                        Description = "Prosta klawiatura",
                        Category = "Peryferia",
                        Price = 75
                    },
                    new Product
                    {
                        Name = "Dysk HDD",
                        Description = "Przenośny dysk twardy",
                        Category = "Dyski",
                        Price = 1200
                    }
                );
                context.SaveChanges();
            }
        }

    }
}
