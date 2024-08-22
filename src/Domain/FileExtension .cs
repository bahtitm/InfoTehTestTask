namespace Domain
{
    public class FileExtension : BaseEntity
    {
        public string? Type { get; set; }
        public string? Icon { get; set; }
        public uint FileId { get; set; }
        public virtual FolderFile? Folder { get; set; }

    }
}
