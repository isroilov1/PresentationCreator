namespace Domain.Models;

public class Presentation
{
    public int Id { get; set; }
    public string Theme { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public byte PageNumber { get; set; }
    public int Template { get; set; }
    public List<string> ImagesPaths { get; set; } = null!;
}
