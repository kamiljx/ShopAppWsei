using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopAppWsei.Models;

namespace ShopAppWsei.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private readonly EFProductRepository _productRepository;
        public NavigationMenuViewComponent(IProductRepository productRepository)
        {
            _productRepository = (EFProductRepository)productRepository;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(_productRepository.Products.Select(x => x.Category).OrderBy(x => x));
        }
    }
}