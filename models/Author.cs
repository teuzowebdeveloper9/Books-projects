using System.ComponentModel.DataAnnotations;

namespace apiBook.models
{
  public class AuthorModel
  {
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }
  }
}