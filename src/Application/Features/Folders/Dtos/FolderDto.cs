namespace Application.Features.Folders.Dtos
{
   public class FolderDto
    {
        public uint Id { get; set; }
        public uint ParentId { get; set; }
        public string? Name { get; set; }
    }
}
