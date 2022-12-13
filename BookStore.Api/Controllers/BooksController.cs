using BookApi.Converters;
using BookApi.Repositories;
using BookStore.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IProductRepository productRepository;
      

        public BooksController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
           
        }

        //public async Task<ActionResult<IEnumerable<BooksDto>>> GetBooks()

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            try
            {
                var books = await productRepository.GetBooks();
                var booksCategories = await productRepository.GetCategories();
                if (books == null || booksCategories == null)
                {
                    return NotFound();
                }
                else {
                    var booksDto = books.ConvertToDto(booksCategories);
                    return Ok(booksDto);
                }
            
            } catch (Exception) {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Retreiving data from the database");
            }
        }
    }
}
