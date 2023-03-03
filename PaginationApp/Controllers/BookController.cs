using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PaginationApp.Repositories;

namespace PaginationApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        [HttpGet("books/{page}")]
        public async Task<IActionResult> GetBooks(int page=1)
        {
            var result = await _bookRepository.GetBooks(page);
            if (result.Count<=0)
            {
                return NotFound("Page not found!");
            }
            return Ok(result);
        }
    }
}
