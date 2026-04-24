using BooksCatalogApi.Models;

namespace BooksCatalogApi.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetBooksAsync();
        Task<Book> CreateBookAsync(Book book);
        Task<bool> DeleteBookAsync(int id);
    }
}
