using Microsoft.AspNetCore.Mvc;
using Mod10DemoTesting.Models;
using Mod10DemoTesting.Repositories;
using Mod10DemoTesting.Controllers;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IndexModelShouldContainAllProducts()
        {
            // Arrange
            IProductRepository fakeProductRepository = new FakeProductRepository();
            ProductController productController = new ProductController(fakeProductRepository);
            // Act
            ViewResult viewResult = productController.Index() as ViewResult;
            List<Product> products = viewResult.Model as List<Product>;
            // Assert
            Assert.AreEqual(products.Count, 3);
        }


        [TestMethod]
        public void GetProductModelShouldContainTheRightProduct()
        {
            // Arrange
            var fakeProductRepository = new FakeProductRepository();
            var productController = new ProductController(fakeProductRepository);
            // Act
            var viewResult = productController.GetProduct(2) as ViewResult;
            Product product = viewResult.Model as Product;
            // Assert
            Assert.AreEqual(product.Id, 2); // comparing actual result expected
        }
    }
}