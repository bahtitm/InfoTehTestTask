using Application.Features.Folders.Dtos;

namespace Application.Features.Folders.Commands.UpdateFolderName
{
    public class UpdateFolderNameCommand : IRequest<FolderDto>
    {
        public uint Id { get; set; }
        public string? Name { get; set; }
    }
}
