using BookApi.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

namespace TestBookProject.Systems.Controllers
{
    public class BooksControllerTest
    {

        // need to reference the repository mock
        [Fact]
        public async Task Get_OnSuccess_return_code_200()
        {
            var controller = new BooksController();

            var result =(OkObjectResult) await controller.GetBooks();

            result.StatusCode.Should().Be(200);

        }
        [Fact]
        public async Task Get_Failure_return_code_500()
        {
            var controller = new BooksController();

            var result = (OkObjectResult)await controller.GetBooks();
            //check for server error message

            result.StatusCode.Should().Be(500);

        }
        [Fact]
        public async Task Get_Exception_Ocuured()
        {
           //to be implemented

        }
        [Fact]
        public async Task Get_OnSuccess_return_code_200()
        {
            var controller = new BooksController();

            var result = (OkObjectResult)await controller.GetBooks();

            result.StatusCode.Should().Be(200);

        }
    }
}