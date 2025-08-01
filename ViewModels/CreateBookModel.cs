namespace apiBook.DTOs
{
  public class CreateBookModel
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime launch { get; set; }
    public int AuthorId { get; set; }
  }
}