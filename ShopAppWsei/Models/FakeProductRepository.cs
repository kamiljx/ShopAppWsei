using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopAppWsei.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { ID= 1, Name = "Laptop", Description = "Portable personal computer", Price = 1200, Category = "Laptop / Desktop"},
            new Product { ID= 2, Name = "Monitor", Description = "Output device to display screen", Price = 399, Category = "Displays" },
            new Product {ID= 3,  Name = "External SSD Disk", Description = "Portable storage device", Price = 150, Category = "Disk"},
        }.AsQueryable<Product>();
    }
}
  