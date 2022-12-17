using BookApi.Repositories;
using FluentAssertions;
using Moq;
using Microsoft.AspNetCore.Mvc;
using BookApi.Controllers;
using Microsoft.AspNetCore.Http;
using BookStore.Models.Dtos;

namespace BookStore.Testing.Systems.Controllers
{
    public class TestBooksControllers
    {
        [Fact]
        public async Task GetOnSuccessReturn200()
        {
            var mokRepo = new Mock<IProductRepository>();
            var controller = new BooksController(mokRepo.Object);


            var result = (OkObjectResult)await controller.GetBooks();

            result.StatusCode.Should().Be(200);
        }

        [Fact]
        public async Task OnSuccessReturnCorrectObject()
        {
            var mokRepo = new Mock<IProductRepository>();
            var controller = new BooksController(mokRepo.Object);

            var result = (OkObjectResult)await controller.GetBooks();

            Assert.IsType<OkObjectResult>(result as OkObjectResult);
        }

        [Fact]
        public async Task OnSuccessReturnCorrectNumberOfBooks()
        {
            var mokRepo = new Mock<IProductRepository>();
            var controller = new BooksController(mokRepo.Object);

            var result = (OkObjectResult)await controller.GetBooks();

            var items = Assert.IsType<List<BooksDto>>(result.Value);
            Assert.Equal(0, items.Count);
        }
    }
}