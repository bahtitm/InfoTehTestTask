using Application.Features.FolderFiles.Dtos;

namespace Application.Features.FolderFiles.Commands.UpdateFolderFile
{
    public class UpdateFolderFileCommand : IRequest<FolderFileDto>
    {
        public uint Id { get; set; }
    }
}
