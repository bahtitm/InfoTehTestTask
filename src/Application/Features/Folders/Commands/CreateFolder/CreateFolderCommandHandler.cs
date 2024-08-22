using Application.Features.Folders.Dtos;

namespace Application.Features.Folders.Commands.CreateFolder
{
    internal class CreateFolderCommandHandler : IRequestHandler<CreateFolderCommand, FolderDto>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public CreateFolderCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<FolderDto> Handle(CreateFolderCommand request, CancellationToken cancellationToken)
        {
            var folder = mapper.Map<Folder>(request);
            await dbContext.AddAsync(folder);
            await dbContext.SaveChangesAsync();
            return mapper.Map<FolderDto>(folder);
        }
    }
}
