using System;
using System.Collections.Generic;
using System.Linq;
using ShopAppWsei.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShopAppWsei.Controllers
{
    public class AdminController : Controller
    {
        private IProductRepository repository;
        public AdminController(IProductRepository repo)
        {
            repository = repo;
        }


        public ViewResult Index() =>
            View(repository.Products);
        public ViewResult Edit(int ID)=>
            View(repository.Products.FirstOrDefault(p => p.ID == p.ID));
        
        [HttpPost]



       public IActionResult Save(Product product)
        {
            if (ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = $"zapisano {product.Name} o numerze id {product.ID}";
                return RedirectToAction("index");
            }
            else
            {
            return View("Edit", product);
            }

        }
    }
}
