using apiBook.data;
using apiBook.DTOs;
using apiBook.models;
using Microsoft.EntityFrameworkCore;

namespace apiBook.services
{
  public class BookServices : IBookService
  {
    private readonly AppDbContext _context;
    public BookServices(AppDbContext context)
    {
      _context = context;
    }

    public Task<ResponseModel<BookModel>> CreateBook(CreateBookModel book)
    {
      throw new NotImplementedException();
    }



    public Task<ResponseModel<BookModel>> DeleteBook(int idBook)
    {
      throw new NotImplementedException();
    }

    public Task<ResponseModel<List<BookModel>>> GetBook()
    {
      throw new NotImplementedException();
    }

    public async Task<ResponseModel<BookModel>> GetBookById(int id)
    {
      ResponseModel<BookModel> response = new ResponseModel<BookModel>();
      try
      {

        var books = await _context.books
                      .Include(a => a.Author)
        .FirstOrDefaultAsync(a => a.Id == id);

        if (books == null)
        {
          response.Mensage = "there is no author with that id try again";
          response.Status = false;
          return response;
        }
        response.Data = books;
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

    public Task<ResponseModel<BookModel>> UpdateBook(UpdateBookModel book)
    {
      throw new NotImplementedException();
    }


  }
}