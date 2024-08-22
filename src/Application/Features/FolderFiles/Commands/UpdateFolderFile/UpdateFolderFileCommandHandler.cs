using Application.Features.FolderFiles.Dtos;

namespace Application.Features.FolderFiles.Commands.UpdateFolderFile
{
    internal class UpdateFolderFileCommandHandler : IRequestHandler<UpdateFolderFileCommand, FolderFileDto>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public UpdateFolderFileCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<FolderFileDto> Handle(UpdateFolderFileCommand request, CancellationToken cancellationToken)
        {
            var folderFile = await dbContext.FindByIdAsync<FolderFile>(request.Id);
            mapper.Map(request, folderFile);
            await dbContext.SaveChangesAsync();
            return mapper.Map<FolderFileDto>(folderFile);
        }
    }
}
