using Microsoft.EntityFrameworkCore;
using BooksCatalogApi.Models;

namespace BooksCatalogApi.Data
{
    public class AppDbContext : DbContext
    {
        // costruttore che usiamo per ricevere la StringConnection dal Program.cs
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Ogni DbSet<> rappresenta una tabella nel DB 
        public DbSet<Book> Books { get; set; }
        //public DbSet<Author> Authors { get; set; }
    }
}
