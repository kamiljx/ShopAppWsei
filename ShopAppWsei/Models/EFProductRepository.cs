using System;
using System.Collections.Generic;
using System.Linq;
using ShopAppWsei.Models;

namespace ShopAppWsei.Models
{
    public class EFProductRepository : IProductRepository 
    {
        private readonly AppDbContext _ctx;

        public EFProductRepository(AppDbContext ctx)
        {
            this._ctx = ctx;
        }
        public IQueryable<Product> Products => _ctx.Products;
    }
}
