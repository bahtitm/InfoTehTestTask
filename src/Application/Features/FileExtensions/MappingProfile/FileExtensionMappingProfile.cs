using Application.Features.FileExtensions.Commands.CreateFileExtension;
using Application.Features.FileExtensions.Commands.UpdateFileExtension;
using Application.Features.FileExtensions.Dtos;

namespace Application.Features.FileExtensions.MappingProfile
{
    internal class FileExtensionMappingProfile : Profile
    {
        public FileExtensionMappingProfile()
        {
            CreateMap<CreateFileExtensionCommand, FileExtension>();
            CreateMap<UpdateFileExtensionCommand, FileExtension>();
            CreateMap<FileExtension, FileExtensionDto>();
        }
    }
}
