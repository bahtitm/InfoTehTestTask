namespace Domain
{
    public class File : BaseEntity
    {
        public string? Name { get; set; }
        public string? Discribtion { get; set; }
        public string? Content { get; set; }
        public uint FolderId { get; set; }
        public virtual Folder? Folder { get; set; }
        public virtual IEnumerable<FileEextension>? FileEextensions { get; set; }
    }
}
