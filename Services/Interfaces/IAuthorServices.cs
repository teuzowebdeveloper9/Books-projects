using apiBook.DTOs;
using apiBook.models;

namespace apiBook.services
{
  public interface IAuthorServices
  {
    Task<ResponseModel<List<AuthorModel>>> GetAuthors();
    Task<ResponseModel<AuthorModel>> GetAuthorById(int id);
    Task<ResponseModel<AuthorModel>> GetAuthorByBookId(int BookId);
    Task<ResponseModel<AuthorModel>> CreateAuthor(CreateAuthorModel author);
    Task<ResponseModel<AuthorModel>> UpdateAuthor(UpdateAuthorModel author);
    Task<ResponseModel<AuthorModel>> DeleteAuthor(int idAuthor);


  }
}