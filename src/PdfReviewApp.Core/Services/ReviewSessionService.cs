using PdfReviewApp.Core.Interfaces;
using PdfReviewApp.Core.Models;

namespace PdfReviewApp.Core.Services;

public sealed class ReviewSessionService
{
    private readonly IProjectRepository _projectRepository;
    private readonly IAnnotationRepository _annotationRepository;

    public ReviewSessionService(IProjectRepository projectRepository, IAnnotationRepository annotationRepository)
    {
        _projectRepository = projectRepository;
        _annotationRepository = annotationRepository;
    }

    public Task SaveProjectAsync(ReviewProject project, CancellationToken cancellationToken = default)
    {
        project.UpdatedAt = DateTimeOffset.UtcNow;
        return _projectRepository.SaveAsync(project, cancellationToken);
    }

    public Task AddAnnotationAsync(Annotation annotation, CancellationToken cancellationToken = default)
        => _annotationRepository.SaveAsync(annotation, cancellationToken);
}
