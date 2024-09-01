using Application.Features.Folders.Dtos;

namespace Application.Features.Folders.Commands.UpdateFolderName
{
    internal class UpdateFolderNameCommandHandler : IRequestHandler<UpdateFolderNameCommand, FolderDto>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public UpdateFolderNameCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<FolderDto> Handle(UpdateFolderNameCommand request, CancellationToken cancellationToken)
        {
            var folder = await dbContext.FindByIdAsync<Folder>(request.Id);
            folder.Name = request.Name;
            await dbContext.SaveChangesAsync();
            return mapper.Map<FolderDto>(folder);
        }
    }
}
