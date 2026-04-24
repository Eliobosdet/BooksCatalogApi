using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BooksCatalogApi.Data;
using BooksCatalogApi.Models;
using BooksCatalogApi.Services;

namespace BooksCatalogApi.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            var books = await _bookService.GetBooksAsync();
            return Ok(books);
        }

        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            var newBook = await _bookService.CreateBookAsync(book);
            return Ok(newBook);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var deleted = await _bookService.DeleteBookAsync(id);
            if(!deleted) return NotFound();
            return NoContent();
        }
    }
}
