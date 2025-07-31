using apiBook.DTOs;
using apiBook.models;
using apiBook.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiBook.controllers
{
  [Route("api/authors")]
  [ApiController]
  public class AuthorController : ControllerBase
  {
    private readonly IAuthorServices _authorServices;
    public AuthorController(IAuthorServices authorServices)
    {
      _authorServices = authorServices;
    }

    [HttpGet]
    public async Task<ActionResult<ResponseModel<List<AuthorModel>>>> GetAuthors()
    {
      var response = await _authorServices.GetAuthors();
      return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ResponseModel<AuthorModel>>> GetAuthorById(int id)
    {
      var response = await _authorServices.GetAuthorById(id);
      return Ok(response);
    }

    [HttpGet("book/{bookId}")]
    public async Task<ActionResult<ResponseModel<AuthorModel>>> GetAuthorByBookId(int bookId)
    {
      var response = await _authorServices.GetAuthorByBookId(bookId);
      return Ok(response);
    }
    [HttpPost]
    public async Task<ActionResult<ResponseModel<AuthorModel>>> CreateAuthor([FromBody] CreateAuthorModel author)
    {
      var response = await _authorServices.CreateAuthor(author);
      return Ok(response);
    }
    [HttpDelete("{id}")]
    public async Task<ActionResult<ResponseModel<AuthorModel>>> DeleteAuthor(int id)
    {
      var response = await _authorServices.DeleteAuthor(id);
      return NoContent();
    }
    [HttpPut]
    public async Task<ActionResult<ResponseModel<AuthorModel>>> UpdateAuthor([FromBody] UpdateAuthorModel author)
    {
      var response = await _authorServices.UpdateAuthor(author);
      return Ok(response);
    }
  }
}