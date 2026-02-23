namespace DenzelPortfolio.Models;

public class CVModel
{
    public string Name { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public List<SkillCategory> SkillCategories { get; set; } = new();
    public List<Project> Projects { get; set; } = new();
    public List<string> Tools { get; set; } = new();
    public List<string> Strengths { get; set; } = new();
}

public class SkillCategory
{
    public string Title { get; set; } = string.Empty;
    public List<string> Skills { get; set; } = new();
}

public class Project
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string GitHubUrl { get; set; } = string.Empty;
    public List<string> Technologies { get; set; } = new();
}
