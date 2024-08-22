using Application.Features.Folders.Dtos;

namespace Application.Features.Folders.Commands.CreateFolder
{
    public class CreateFolderCommand : IRequest<FolderDto>
    {
        public uint ParentId { get; set; }
        public string? Name { get; set; }
    }
}
