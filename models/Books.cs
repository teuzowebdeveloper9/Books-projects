using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace apiBook.models
{
  public class BookModel
  {
    [Key]
    public int Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public DateTime launch { get; set; }

    [JsonIgnore]
    public AuthorModel Author { get; set; }



  }
}