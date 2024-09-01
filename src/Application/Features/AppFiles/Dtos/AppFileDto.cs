namespace Application.Features.AppFiles.Dtos
{
    public class AppFileDto
    {
        public uint Id { get; set; }
        public string? Name { get; set; }
        public string? Discribtion { get; set; }
        public string? Content { get; set; }
        public uint FolderId { get; set; }

        public uint FileExtensionId { get; set; }
    }
}
