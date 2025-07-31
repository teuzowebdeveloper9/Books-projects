using apiBook.data;
using apiBook.DTOs;
using apiBook.models;
using Microsoft.EntityFrameworkCore;

namespace apiBook.services
{
  public class AuthorServices : IAuthorServices
  {
    private readonly AppDbContext _context;

    public AuthorServices(AppDbContext context)
    {
      _context = context;
    }

    public async Task<ResponseModel<AuthorModel>> GetAuthorByBookId(int BookId)
    {
      ResponseModel<AuthorModel> response = new ResponseModel<AuthorModel>();
      try
      {

        var author = await _context.authors
                      .Include(a => a.Books)
        .FirstOrDefaultAsync(a => a.Books.Any(b => b.Id == BookId));

        if (author == null)
        {
          response.Mensage = "There is no author with a book using the given BookId.";
          response.Status = false;
          return response;
        }
        response.Data = author;
        response.Mensage = "success in catching author";
        response.Status = true;
        return response;
      }
      catch (Exception e)
      {
        response.Mensage = e.Message;
        response.Status = false;
        return response;
      }
    }

    public async Task<ResponseModel<AuthorModel>> GetAuthorById(int id)
    {
      ResponseModel<AuthorModel> response = new ResponseModel<AuthorModel>();
      try
      {

        var author = await _context.authors
                      .Include(a => a.Books)
        .FirstOrDefaultAsync(a => a.Id == id);

        if (author == null)
        {
          response.Mensage = "there is no author with that id try again";
          response.Status = false;
          return response;
        }
        response.Data = author;
        response.Mensage = "success in catching author";
        response.Status = true;
        return response;
      }
      catch (Exception e)
      {
        response.Mensage = e.Message;
        response.Status = false;
        return response;
      }
    }

    public async Task<ResponseModel<List<AuthorModel>>> GetAuthors()
    {
      ResponseModel<List<AuthorModel>> response = new ResponseModel<List<AuthorModel>>();
      try
      {
        var authors = await _context.authors.ToListAsync();

        response.Data = authors;

        response.Mensage = "success in catching all authors";

        response.Status = true;

        return response;

      }
      catch (Exception e)
      {
        response.Mensage = e.Message;
        response.Status = false;
        return response;
      }
    }
  }
}