using Application.Features.AppFiles.Commands.CreateFolderFile;
using Application.Features.AppFiles.Commands.UpdateAppFile;
using Application.Features.AppFiles.Dtos;

namespace Application.Features.AppFiles.MappingProfile
{
    internal class AppFileMappingProfile : Profile
    {
        public AppFileMappingProfile()
        {
            CreateMap<CreateAppFileCommand, AppFile>();
            CreateMap<UpdateAppileCommand, AppFile>();
            CreateMap<AppFile, AppFileDto>();
        }
    }
}
