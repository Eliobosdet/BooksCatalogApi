using BooksCatalogApi.Data;
using BooksCatalogApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksCatalogApi.Services
{
    

    public class BookService : IBookService
    {
        private readonly AppDbContext _dbContext;

        public BookService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Book>> GetBooksAsync()
        {
            return await _dbContext.Books.ToListAsync();
        }

        public async Task<Book> CreateBookAsync(Book book)
        {
            _dbContext.Books.Add(book);
            await _dbContext.SaveChangesAsync();
            return book;
        }

        public async Task<bool> DeleteBookAsync(int id)
        {
            var book = await _dbContext.Books.FindAsync(id);
            if (book == null) return false;
            _dbContext.Books.Remove(book);
            await _dbContext.SaveChangesAsync();
            return true;
        }

    }
}
