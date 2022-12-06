using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    public class BooksController : Controller
    {
        public BooksController()
        {
           
        }


        [HttpGet(Name = "GetBookList")]
        public async Task<IActionResult> Get()
        {
            return Ok("success");
        }
    }
}
