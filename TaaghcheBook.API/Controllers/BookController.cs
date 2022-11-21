using Microsoft.AspNetCore.Mvc;
using TaaghcheBook.Application.Service;
using TaaghcheBook.Core;

namespace TaaghcheBook.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _service;
        public BookController(IBookService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> Get(int id)
        {
            try
            {
                var book = await _service.GetBook(id);
                if(book == null)
                {
                    return NotFound();
                }
                return Ok(book);

            } catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
