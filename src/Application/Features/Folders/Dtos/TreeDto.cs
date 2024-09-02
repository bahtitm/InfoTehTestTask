using Application.Features.AppFiles.Dtos;

namespace Application.Features.Folders.Dtos
{
   public class TreeDto
    {
        public uint Id { get; set; }
        public uint ParentId { get; set; }
        public string? Name { get; set; }

        public bool IsFile { get; set; }
        public uint FileId { get; set; }

        public uint ExtensionId { get; set; }

        public virtual IEnumerable<AppFileDto>? Files { get; set; }
        
    }
}
