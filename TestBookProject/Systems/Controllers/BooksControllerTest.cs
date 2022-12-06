using BookApi.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

namespace TestBookProject.Systems.Controllers
{
    public class BooksControllerTest
    {
        [Fact]
        public async Task Get_OnSuccess_return_code_200()
        {
            var controller = new BooksController();

            var result =(OkObjectResult) await controller.Get();

            result.StatusCode.Should().Be(200);

        }
    }
}