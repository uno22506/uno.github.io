namespace PdfReviewApp.Core.Models;

public sealed class DocumentReference
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public required string FilePath { get; init; }
    public required string ContentHash { get; init; }
    public int PageCount { get; init; }
}
