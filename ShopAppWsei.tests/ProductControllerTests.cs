using System;
using Xunit;
using Moq;
using ShopAppWsei.Models;
using ShopAppWsei.Controllers;
using System.Linq;

namespace ShopAppWsei.tests
{
    public class ProductControllerTests
    {

        [Fact]
        public void Get_Product_By_Id()
        {
            //arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new Product[]
            {
                new Product {ID = 1 , Name = "P1"},
                new Product {ID = 2 , Name = "P2"},
                new Product {ID = 3 , Name = "P3"},
                new Product {ID = 4 , Name = "P4"},
                new Product {ID = 5 , Name = "P5"}
            }.AsQueryable<Product>());

            ProductController controller = new ProductController(mock.Object);
            //act
            var result = controller.GetProductById(3);
            //Product product = result.ViewData.Model as Product;  

            //assert
            Assert.Equal("P3", result.Name);
        }
        [Fact]
        public void CanGetAllProducts()
        {

            // Arrange
            Mock<IProductRepository> productRepositoryMock = new Mock<IProductRepository>();
            Product[] productModelMock = new Product[] {
                new Product {ID = 1, Name = "P1"},
                new Product {ID = 2, Name = "P2"},
                new Product {ID = 3, Name = "P3"},
            };
            productRepositoryMock.Setup(x => x.Products).Returns(productModelMock.AsQueryable<Product>());

            ProductController controller = new ProductController(productRepositoryMock.Object);

            // Act
            Product[] result = (controller.GetProductListAll().ViewData.Model as IQueryable<Product>).ToArray();

            // Assert
            Assert.True(result.Length == productModelMock.Length);
        }
    }
}
