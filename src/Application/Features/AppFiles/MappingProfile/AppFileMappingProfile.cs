using Application.Features.AppFiles.Commands.CreateFolderFile;
using Application.Features.AppFiles.Commands.UpdateAppFile;
using Application.Features.AppFiles.Dtos;

namespace Application.Features.AppFiles.MappingProfile
{
    internal class AppFileMappingProfile : Profile
    {
        public AppFileMappingProfile()
        {
            CreateMap<CreateAppFileCommand, AppFile>()

                .ForMember(ds=>ds.File, op=>op.Ignore())
                ;
            CreateMap<UpdateAppFileCommand, AppFile>();
            CreateMap<AppFile, AppFileDto>();
        }
    }
}
