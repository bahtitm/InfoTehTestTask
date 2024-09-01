using Application.Features.Folders.Commands.CreateFolder;
using Application.Features.Folders.Commands.UpdateFolder;
using Application.Features.Folders.Dtos;

namespace Application.Features.Folders.MappingProfile
{
    public class FolderMappingProfile : Profile
    {
        public FolderMappingProfile()
        {
            CreateMap<CreateFolderCommand, Folder>();
            CreateMap<UpdateFolderCommand, Folder>();
            CreateMap<Folder, FolderDto>();
            CreateMap<Folder, TreeDto>()
                .ForMember(dest => dest.Files, opt => opt.MapFrom(src => src.FolderFiles));
            ;
        }
    }
}
