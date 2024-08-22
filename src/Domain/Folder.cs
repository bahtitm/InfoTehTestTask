namespace Domain
{
    public class Folder : BaseEntity
    {
        public uint ParentId { get; set; }
        public string? Name { get; set; }
        public virtual IEnumerable<File>? Files { get; set; }
    }
}
