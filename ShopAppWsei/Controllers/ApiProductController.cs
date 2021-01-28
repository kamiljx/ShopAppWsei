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



        /// <summary>
        /// Pobranie produktu o określonym ID
        /// <param name="ID"></param>
        /// </summary>

        [HttpGet("{ID}")]

        public ActionResult<Product>Get(int ID)
        {
            var product = repository.Products.FirstOrDefault(p => p.ID == p.ID);
            if (product == null)
                return NotFound();
            return Ok(product);
        }
        /// <summary>
        /// Pobranie wszystkich produktów
        /// </summary>
        [HttpGet]
        public IEnumerable<Product> Get() => repository.Products;


        /// <summary>
        /// Dodanie produktu
        /// </summary>
        /// 
        [HttpPost]
        public Product Post([FromBody] Product product) =>
            repository.AddProduct(new Product
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Category = product.Category
            });


        /// <summary>
        /// Edytowanie produktu o wskazanym ID  
        /// </summary>


        [HttpPut]
        public bool Put([FromBody] Product product) =>
            repository.EditProduct(product);





        /// <summary>
        /// Usunięcie produktu o wskazanym ID  
        /// </summary>
        /// <param name="ID"></param>
        [HttpDelete("{ID}")]

        public ActionResult<Product> Delete(int ID)
        {
            var product = repository.DeleteProduct(ID);
            if (product == null)
                return NotFound();
            return Ok(product);
        }



            //[HttpGet]
            //public ActionResult GetProduct()
            //{
            //    var ProductList = repository.Products.Where(product = Product);
            //    return Ok(ProductList);
            //}








            //public IEnumerable<Product> GetProducts() => repository.

        }

}