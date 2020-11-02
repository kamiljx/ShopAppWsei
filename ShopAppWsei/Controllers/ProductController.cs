using System;
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

        public ViewResult List() => View(productRepository.Products);
        public IActionResult Index()
        {
            return View();
        }
    }


}