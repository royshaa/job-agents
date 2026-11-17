namespace JobAgents.Api.Models;
using System.ComponentModel.DataAnnotations;

public class JobPosting
{
    public int Id { get; set; }
    [StringLength(200, MinimumLength = 2),  Required]
    public required string Title { get; set; }
    [StringLength(100, MinimumLength = 2), Required]
    public required string Company { get; set; }

    [StringLength(100)]
    public string? Location { get; set; }
    [Url]
    public string? Url { get; set; }

    [StringLength(5000)]
    public string? Description { get; set; }

    public DateTimeOffset CreatedAt { get; set; }
}
