using System;
using ShopAppWsei.Controllers;
using ShopAppWsei.Models;
using Xunit;
using System.Linq;
namespace ShopAppWsei.tests
{
    public class ProductModelTests
    {

        [Fact]
        public void CanChangeProductID()
        {

            // Arrange
            var p = new Product {ID = 1, Name = "Dysk", Price = 29, Description = "Dysk SSD", Category = "Dyski" };

            // Act
            p.ID = 323312315;

            //Assert
            Assert.Equal(323312315, p.ID);
        }
        [Fact]
        public void CanChangeProductName()
        {
            //Arrange
            var p = new Product { ID = 1, Name = "Dysk Samsung", Price = 199, Description = "Dysk SSD Super Fast", Category = "Dyski", };

            //Act
            p.Name = "Dysk Huawei";

            //Assert
            Assert.Equal("Dysk Huawei", p.Name);
        }
        [Fact]
        public void CanChangeProductDescription()
        {
            //Arrange
            var p = new Product { ID = 1, Name = "Dysk Samsung", Price = 199, Description = "Dysk SSD Super Fast", Category = "Dyski", };

            //Act
            p.Description = "Dysk HDD dobrej jakości";

            //Assert
            Assert.Equal("Dysk HDD dobrej jakości", p.Description);
        }
        [Fact]
        public void CanChangeProductPrice()
        {
            //Arrange
            var p = new Product { ID = 1, Name = "Dysk Samsung", Price = 199, Description = "Dysk SSD Super Fast", Category = "Dyski", };

            //Act
            p.Price = 50;

            //Assert
            Assert.Equal(50, p.Price);
        }
    }
}
