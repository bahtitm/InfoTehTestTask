namespace Domain
{
    public class FileEextension : BaseEntity
    {
        public string? Type { get; set; }
        public string? Icon { get; set; }
        public uint FileId { get; set; }
        public virtual File? Folder { get; set; }

    }
}
