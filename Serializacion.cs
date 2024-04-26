namespace Fundamentos;

public class Serializacion // JSONParse
{
  public List<Todos>? Data { get; set; }
}

public class Todos
{
  public int userId { get; set; }
  public int id { get; set; }
  public string? title { get; set; }
  public bool completed { get; set; }
}
