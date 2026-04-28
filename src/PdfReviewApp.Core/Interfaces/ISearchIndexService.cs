using PdfReviewApp.Core.Models;

namespace PdfReviewApp.Core.Interfaces;

public interface ISearchIndexService
{
    Task RebuildIndexAsync(string rootDirectory, CancellationToken cancellationToken = default);
    Task<IReadOnlyList<SimilarityCandidate>> FindSimilarPagesAsync(Guid documentId, int pageNumber, int take = 20, CancellationToken cancellationToken = default);
    Task<IReadOnlyList<SimilarityCandidate>> SearchByKeywordAsync(string keyword, int take = 50, CancellationToken cancellationToken = default);
}
