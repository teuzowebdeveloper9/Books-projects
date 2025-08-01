using apiBook.DTOs;
using apiBook.models;
using apiBook.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiBook.controllers
{
  [Route("api/books")]
  [ApiController]
  public class LivroController : ControllerBase
  {
    private readonly IBookService _bookService;
    public LivroController(IBookService bookService)
    {
      _bookService = bookService;
    }
    [HttpGet("{bookId}")]
    public async Task<ActionResult<ResponseModel<AuthorModel>>> getBookById([FromRoute] int bookId)
    {
      var book = await _bookService.GetBookById(bookId);
      return Ok(book);
    }
    [HttpPut]
    public async Task<ActionResult<ResponseModel<BookModel>>> UpdateBook([FromBody] UpdateBookModel book)
    {
      var response = await _bookService.UpdateBook(book);
      return Ok(response);
    }
    [HttpGet]
    public async Task<ActionResult<ResponseModel<List<BookModel>>>> GetBook()
    {
      var response = await _bookService.GetBook();
      return Ok(response);
    }
    [HttpDelete("{bookId}")]
    public async Task<ActionResult<ResponseModel<BookModel>>> DeleteBook([FromRoute] int bookId)
    {
      var response = await _bookService.DeleteBook(bookId);
      return Ok(response);
    }

  }
}