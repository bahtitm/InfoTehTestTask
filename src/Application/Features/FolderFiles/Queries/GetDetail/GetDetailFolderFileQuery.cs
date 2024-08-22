using Application.Features.FolderFiles.Dtos;

namespace Application.Features.FolderFiles.Queries.GetDetail
{
    public record GetDetailFolderFileQuery(uint id) : IRequest<FolderFileDto>;
}
