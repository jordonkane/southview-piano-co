using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using piano_store.Controllers;
using piano_store.Models;
using piano_store.Models.Interfaces;
using Xunit;

namespace piano_store.Tests.Controller
{
    public class HomeControllerTests
    {
        private IProductRepository productRepository;
        public HomeControllerTests()
        {
            // Dependencies
            productRepository = A.Fake<IProductRepository>();
        }

        [Fact]
        public void CanGetTrendingProducts()
        {
            var result = productRepository.GetTrendingProducts();
            Assert.NotNull(result);
        }

        [Fact]
        public void Index_ReturnsViewResult_WithTrendingProducts()
        {
            // Arrange
            var fakeProducts = new List<Product> { new Product(), new Product() };
            A.CallTo(() => productRepository.GetTrendingProducts()).Returns(fakeProducts);
            var controller = new HomeController(productRepository);

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal(fakeProducts, viewResult.Model);
        }

    }
}
