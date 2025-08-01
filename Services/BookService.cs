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



    public async Task<ResponseModel<BookModel>> DeleteBook(int idBook)
    {
      ResponseModel<BookModel> response = new ResponseModel<BookModel>();
      try
      {
        var excludeBook = await _context.books.FindAsync(idBook);
        if (excludeBook == null)
        {
          response.Mensage = "There is no book with that id try again";
          response.Status = false;
          return response;
        }
        _context.books.Remove(excludeBook);
        await _context.SaveChangesAsync();
        response.Data = excludeBook;
        response.Mensage = "success in deleting book";
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

    public async Task<ResponseModel<List<BookModel>>> GetBook()
    {
      ResponseModel<List<BookModel>> response = new ResponseModel<List<BookModel>>();
      try
      {
        var books = await _context.books.ToListAsync();

        response.Data = books;

        response.Mensage = "success in catching all books";

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

    public async Task<ResponseModel<BookModel>> UpdateBook(UpdateBookModel book)
    {
      ResponseModel<BookModel> response = new ResponseModel<BookModel>();
      try
      {
        var BookToUpdate = await _context.books.FindAsync(book.Id);
        if (BookToUpdate == null)
        {
          response.Mensage = "There is no book with that id try again";
          response.Status = false;
          return response;
        }
        BookToUpdate.Title = book.Title;
        BookToUpdate.Description = book.Description;
        BookToUpdate.launch = book.launch;
        _context.books.Update(BookToUpdate);
        await _context.SaveChangesAsync();
        response.Data = BookToUpdate;
        response.Mensage = "success in updating book";
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