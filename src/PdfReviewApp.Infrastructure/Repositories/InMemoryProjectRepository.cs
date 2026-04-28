using PdfReviewApp.Core.Interfaces;
using PdfReviewApp.Core.Models;

namespace PdfReviewApp.Infrastructure.Repositories;

public sealed class InMemoryProjectRepository : IProjectRepository
{
    private readonly Dictionary<Guid, ReviewProject> _projects = new();

    public Task<ReviewProject?> GetAsync(Guid projectId, CancellationToken cancellationToken = default)
    {
        _projects.TryGetValue(projectId, out var project);
        return Task.FromResult(project);
    }

    public Task<IReadOnlyList<ReviewProject>> ListRecentAsync(int limit = 20, CancellationToken cancellationToken = default)
    {
        IReadOnlyList<ReviewProject> items = _projects.Values
            .OrderByDescending(x => x.UpdatedAt)
            .Take(limit)
            .ToList();
        return Task.FromResult(items);
    }

    public Task SaveAsync(ReviewProject project, CancellationToken cancellationToken = default)
    {
        _projects[project.Id] = project;
        return Task.CompletedTask;
    }
}
