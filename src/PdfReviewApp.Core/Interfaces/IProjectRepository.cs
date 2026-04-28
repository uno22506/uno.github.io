using PdfReviewApp.Core.Models;

namespace PdfReviewApp.Core.Interfaces;

public interface IProjectRepository
{
    Task<ReviewProject?> GetAsync(Guid projectId, CancellationToken cancellationToken = default);
    Task<IReadOnlyList<ReviewProject>> ListRecentAsync(int limit = 20, CancellationToken cancellationToken = default);
    Task SaveAsync(ReviewProject project, CancellationToken cancellationToken = default);
}
