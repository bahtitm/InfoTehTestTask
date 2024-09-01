using Application.Features.FileExtensions.Dtos;

namespace Application.Features.FileExtensions.Commands.CreateFileExtension
{
    public class CreateFileExtensionCommand : IRequest<FileExtensionDto>
    {
        public string? Type { get; set; }
        public string? Icon { get; set; }
    }
}
