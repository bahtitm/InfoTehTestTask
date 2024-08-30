namespace Domain
{
    public class FileExtension : BaseEntity
    {
        public string? Type { get; set; }
        public string? Icon { get; set; }
       
        public virtual IEnumerable<AppFile>? AppFiles { get; set; }
    }
}
