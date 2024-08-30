using Application.Features.Folders.Dtos;

namespace Application.Features.Folders.Queries.GetFolderFileTree
{
    public record GetFolderFileTreeQuery : IRequest<IEnumerable<TreeDto>>;
}
