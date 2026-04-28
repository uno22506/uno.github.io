namespace PdfReviewApp.Core.Models;

public sealed class Annotation
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public required Guid ProjectId { get; init; }
    public required Guid DocumentId { get; init; }
    public required int PageNumber { get; init; }
    public required AnnotationType Type { get; init; }
    public required string ColorHex { get; init; }
    public float Thickness { get; init; } = 2.0f;
    public required string PayloadJson { get; init; }
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;
}
