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
  }
}