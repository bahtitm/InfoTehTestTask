namespace Domain
{
    public class AppFile : BaseEntity
    {
        public string? Name { get; set; }
        public string? Discribtion { get; set; }
        public string? Content { get; set; }
        public uint FolderId { get; set; }
        public virtual Folder? Folder { get; set; }
        public uint FileExtensionId { get; set; }
        public virtual FileExtension? FileExtension { get; set; }
        public byte[] File { get; set; }

    }
}
