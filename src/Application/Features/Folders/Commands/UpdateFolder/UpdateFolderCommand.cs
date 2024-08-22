using Application.Features.Folders.Dtos;

namespace Application.Features.Folders.Commands.UpdateFolder
{
    public class UpdateFolderCommand : IRequest<FolderDto>
    {
        public uint Id { get; set; }
        public uint ParentId { get; set; }
        public string? Name { get; set; }
    }
}
