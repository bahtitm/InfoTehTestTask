using Application.Features.FileExtensions.Dtos;

namespace Application.Features.FileExtensions.Queries.GetAll
{
    public record GetAllFileExtensionQuery : IRequest<IEnumerable<FileExtensionDto>>;

}
