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

    public DbSet<BookModel> books { get; set; }
    public DbSet<AuthorModel> authors { get; set; }
  }
}