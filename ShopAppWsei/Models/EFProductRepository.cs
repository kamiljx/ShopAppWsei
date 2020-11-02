using System;
using System.Collections.Generic;
using System.Linq;
using ShopAppWsei.Models;

namespace ShopAppWsei.Models
{
    public class EFProductRepository : IProductRepository
    {
        private readonly AppDbContext ctx;

        public EFProductRepository(AppDbContext ctx)
        {
            this.ctx = ctx;
        }
        public IQueryable<Product> Products => ctx.Products;
    }
}
