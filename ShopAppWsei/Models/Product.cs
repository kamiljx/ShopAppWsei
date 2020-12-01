using System;
using System.ComponentModel.DataAnnotations;
namespace ShopAppWsei.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Display(Name = "Nazwa")]
        public string Name { get; set; }
        [Display(Name = "Opis")]
        public string Description { get; set; }
        [Range(0.01, double.MaxValue, ErrorMessage = "Proszę podać dodatnią cene")]
        [Display(Name = "Cena label")]
        public decimal Price { get; set; }
        [Display(Name = "Kategoria")]
        public string Category { get; set; }
    }
}
