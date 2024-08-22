using Application.Features.FolderFiles.Commands.CreateFolderFile;
using Application.Features.FolderFiles.Commands.UpdateFolderFile;
using Application.Features.FolderFiles.Dtos;

namespace Application.Features.FolderFiles.MappingProfile
{
    internal class FolderFileMappingProfile : Profile
    {
        public FolderFileMappingProfile()
        {
            CreateMap<CreateFolderFileCommand, FolderFile>();
            CreateMap<UpdateFolderFileCommand, FolderFile>();
            CreateMap<FolderFile, FolderFileDto>();
        }
    }
}
