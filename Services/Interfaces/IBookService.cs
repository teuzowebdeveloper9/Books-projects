using apiBook.DTOs;
using apiBook.models;

namespace apiBook.services
{
  public interface IBookService
  {
    Task<ResponseModel<List<BookModel>>> GetBook();
    Task<ResponseModel<BookModel>> GetBookById(int idBook);
    Task<ResponseModel<BookModel>> CreateBook(CreateBookModel author);
    Task<ResponseModel<BookModel>> UpdateBook(UpdateBookModel author);
    Task<ResponseModel<BookModel>> DeleteBook(int idBook);
  }
}