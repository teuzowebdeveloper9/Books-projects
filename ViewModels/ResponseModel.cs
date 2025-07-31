namespace apiBook.DTOs
{
  public class ResponseModel<T>
  {
    public T? Data { get; set; }

    public string Mensage { get; set; } = string.Empty;

    public bool Status { get; set; } = true;

  }
}