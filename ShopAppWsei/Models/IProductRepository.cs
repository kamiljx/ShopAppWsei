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
    }
}