using apiBook.models;
using Microsoft.EntityFrameworkCore;

namespace apiBook.data
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    DbSet<BookModel> books { get; set; }
    DbSet<AuthorModel> authors { get; set; }
  }
}