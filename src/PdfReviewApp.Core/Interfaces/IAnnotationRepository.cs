using PdfReviewApp.Core.Models;

namespace PdfReviewApp.Core.Interfaces;

public interface IAnnotationRepository
{
    Task<IReadOnlyList<Annotation>> ListByDocumentAsync(Guid projectId, Guid documentId, CancellationToken cancellationToken = default);
    Task SaveAsync(Annotation annotation, CancellationToken cancellationToken = default);
    Task DeleteAsync(Guid annotationId, CancellationToken cancellationToken = default);
}
