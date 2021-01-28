using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ShopAppWsei.Models;

namespace ShopAppWsei.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public ViewResult List(string category) => View(productRepository.Products.Where(p => p.Category == category));
        public IActionResult Index()
        {
            return View();
        }
        public Product GetProductById(int productId)
        {
            Product product = productRepository.Products.Where(x => x.ID == productId).FirstOrDefault();
            return product;
        }
        public ViewResult GetProductListAll()
        {
            return View(productRepository.Products);
        }
    }


}