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

       

        public void SaveProduct (Product product)
        {
            if (product.ID == 0)
            {
                _ctx.Products.Add(product);
            }
            else
            {
                Product dbEntry = _ctx.Products.FirstOrDefault(p => p.ID == product.ID);
                if (dbEntry != null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Description = product.Description;
                    dbEntry.Price = product.Price;
                    dbEntry.Category = product.Category;
                }
            }
            _ctx.SaveChanges();
        }
        public Product AddProduct(Product product)
        {
            _ctx.Products.Add(product);
            _ctx.SaveChanges();

            return product;
        }
        public Product DeleteProduct (int ID)
        {
            Product dbEntry = _ctx.Products.FirstOrDefault(p => p.ID == ID);
            if(dbEntry != null)
            {
                _ctx.Products.Remove(dbEntry);
                _ctx.SaveChanges();
            }
            return dbEntry; 

        }

        public void CreateProduct(Product product)
        {
            _ctx.Products.Add(new Product());
            _ctx.SaveChanges();
        }

        public bool EditProduct(Product product)
        {
            Product dbEntry = _ctx.Products.FirstOrDefault(p => p.ID == product.ID);

            if (dbEntry != null)
            {
                dbEntry.Name = product.Name;
                dbEntry.Description = product.Description;
                dbEntry.Price = product.Price;
                dbEntry.Category = product.Category;
            }else
            {
                return false;
            }
            _ctx.SaveChanges();
            return true;
        }
    }  
}
