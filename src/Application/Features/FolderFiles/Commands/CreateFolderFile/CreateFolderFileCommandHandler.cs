using Application.Features.FolderFiles.Dtos;

namespace Application.Features.FolderFiles.Commands.CreateFolderFile
{
    internal class CreateFolderFileCommandHandler : IRequestHandler<CreateFolderFileCommand, FolderFileDto>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public CreateFolderFileCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<FolderFileDto> Handle(CreateFolderFileCommand request, CancellationToken cancellationToken)
        {
            var folderFile = mapper.Map<FolderFile>(request);
            await dbContext.AddAsync(folderFile);
            await dbContext.SaveChangesAsync();
            return mapper.Map<FolderFileDto>(folderFile);
        }
    }
}
