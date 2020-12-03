using System;
using System.Linq;

namespace ShopAppWsei.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products
        {
            get;
        }

        void SaveProduct(Product product);
        Product DeleteProduct(int iD);
    }
}