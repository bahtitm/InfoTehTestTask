namespace Domain
{
    public class Folder : BaseEntity
    {
        public uint ParentId { get; set; }
        public string? Name { get; set; }
        public virtual IEnumerable<FolderFile>? FolderFiles { get; set; }
    }
}
