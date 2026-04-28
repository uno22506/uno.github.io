namespace PdfReviewApp.Core.Models;

public sealed class ReviewProject
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public required string Name { get; set; }
    public Guid? LeftDocumentId { get; set; }
    public Guid? RightDocumentId { get; set; }
    public int LeftPage { get; set; } = 1;
    public int RightPage { get; set; } = 1;
    public bool IsSyncEnabled { get; set; }
    public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow;
}
