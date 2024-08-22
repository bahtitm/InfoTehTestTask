using Application.Features.Folders.Dtos;

namespace Application.Features.Folders.Queries.GetAll
{
    public record GetAllFolderQuery : IRequest<IEnumerable<FolderDto>>;
}
