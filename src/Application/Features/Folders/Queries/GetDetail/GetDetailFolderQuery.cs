using Application.Features.Folders.Dtos;

namespace Application.Features.Folders.Queries.GetDetail
{
    public record GetDetailFolderQuery(uint id) : IRequest<FolderDto>;
}
