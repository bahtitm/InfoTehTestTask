using Application.Features.FolderFiles.Dtos;

namespace Application.Features.FolderFiles.Queries.GetAll
{
    public record GetAllFolderFileQuery : IRequest<IEnumerable<FolderFileDto>>;
}
