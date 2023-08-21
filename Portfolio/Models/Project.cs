namespace Portfolio.Models;

public class Project
{
    public required int ProjectId { get; set; }

    public string? ProjectName { get; set; }

    public string? ProjectDescription { get; set; }

    public string? ProjectUrl { get; set; }

    public ICollection<string> Technologies { get; set; } = new List<string>();
}
