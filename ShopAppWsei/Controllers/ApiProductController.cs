using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using ShopAppWsei.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ShopAppWsei.Controllers;

namespace ShopAppWsei.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ApiProductController : ControllerBase
    {

        private IProductRepository repository;
        public ApiProductController(IProductRepository repo)
        {
            repository = repo;
        }




        [HttpGet("id")]
        public Product Get(int ID) => repository.Products.FirstOrDefault(p => p.ID == p.ID);

        [HttpGet]
        public IEnumerable<Product> Get() => repository.Products;

        [HttpPost]
        public Product Post([FromBody] Product product) =>
            repository.AddProduct(new Product
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Category = product.Category
            });


        [HttpPut]
        public bool Put([FromBody] Product product) =>
            repository.EditProduct(product);

        [HttpDelete("{ID}")]
        public void Delete(int ID ) => repository.DeleteProduct(ID);
        
        //[HttpGet]
        //public ActionResult GetProduct()
        //{
        //    var ProductList = repository.Products.Where(product = Product);
        //    return Ok(ProductList);
        //}








        //public IEnumerable<Product> GetProducts() => repository.

    }

}