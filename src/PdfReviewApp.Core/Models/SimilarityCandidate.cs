namespace PdfReviewApp.Core.Models;

public sealed class SimilarityCandidate
{
    public required Guid SourceDocumentId { get; init; }
    public required int SourcePage { get; init; }
    public required Guid TargetDocumentId { get; init; }
    public required int TargetPage { get; init; }
    public required double Score { get; init; }
    public string? Snippet { get; init; }
}
