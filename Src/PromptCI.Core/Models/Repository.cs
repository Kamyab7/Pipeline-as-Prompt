namespace PromptCI.Core.Models;

public class Repository
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool Private { get; set; }
}
