namespace apiBook.DTOs
{
  public class UpdateBookModel
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime launch { get; set; }
  }
}