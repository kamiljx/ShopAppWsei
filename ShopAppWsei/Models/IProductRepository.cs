using System;
using System.Linq;

namespace ShopAppWsei.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
       

        void SaveProduct(Product product);
        Product DeleteProduct(int ID);
        bool EditProduct(Product product);
        Product AddProduct(Product product);
        //Product CreateProduct(Product product);

    }
}