using PdfReviewApp.Core.Interfaces;
using PdfReviewApp.Core.Models;

namespace PdfReviewApp.Infrastructure.Repositories;

public sealed class SimpleSearchIndexService : ISearchIndexService
{
    public Task RebuildIndexAsync(string rootDirectory, CancellationToken cancellationToken = default)
    {
        // TODO: Implement SQLite FTS5 indexing.
        return Task.CompletedTask;
    }

    public Task<IReadOnlyList<SimilarityCandidate>> FindSimilarPagesAsync(Guid documentId, int pageNumber, int take = 20, CancellationToken cancellationToken = default)
    {
        IReadOnlyList<SimilarityCandidate> empty = Array.Empty<SimilarityCandidate>();
        return Task.FromResult(empty);
    }

    public Task<IReadOnlyList<SimilarityCandidate>> SearchByKeywordAsync(string keyword, int take = 50, CancellationToken cancellationToken = default)
    {
        IReadOnlyList<SimilarityCandidate> empty = Array.Empty<SimilarityCandidate>();
        return Task.FromResult(empty);
    }
}
