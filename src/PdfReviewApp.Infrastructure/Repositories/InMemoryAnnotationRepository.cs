using PdfReviewApp.Core.Interfaces;
using PdfReviewApp.Core.Models;

namespace PdfReviewApp.Infrastructure.Repositories;

public sealed class InMemoryAnnotationRepository : IAnnotationRepository
{
    private readonly Dictionary<Guid, Annotation> _annotations = new();

    public Task<IReadOnlyList<Annotation>> ListByDocumentAsync(Guid projectId, Guid documentId, CancellationToken cancellationToken = default)
    {
        IReadOnlyList<Annotation> items = _annotations.Values
            .Where(x => x.ProjectId == projectId && x.DocumentId == documentId)
            .OrderBy(x => x.CreatedAt)
            .ToList();
        return Task.FromResult(items);
    }

    public Task SaveAsync(Annotation annotation, CancellationToken cancellationToken = default)
    {
        _annotations[annotation.Id] = annotation;
        return Task.CompletedTask;
    }

    public Task DeleteAsync(Guid annotationId, CancellationToken cancellationToken = default)
    {
        _annotations.Remove(annotationId);
        return Task.CompletedTask;
    }
}
