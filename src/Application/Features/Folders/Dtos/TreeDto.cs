namespace Application.Features.Folders.Dtos
{
   public class TreeDto
    {
        public uint Id { get; set; }
        public uint ParentId { get; set; }
        public string? Name { get; set; }

        public virtual IEnumerable<AppFile>? FolderFiles { get; set; }
    }
}
