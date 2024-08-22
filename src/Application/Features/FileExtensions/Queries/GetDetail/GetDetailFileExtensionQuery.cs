using Application.Features.FileExtensions.Dtos;

namespace Application.Features.FileExtensions.Queries.GetDetail
{
    public record GetDetailFileExtensionQuery(uint id) : IRequest<FileExtensionDto>;
}
