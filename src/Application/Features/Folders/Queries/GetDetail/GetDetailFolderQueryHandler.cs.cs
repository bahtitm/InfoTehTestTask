using Application.Features.Folders.Dtos;

namespace Application.Features.Folders.Queries.GetDetail
{
    public class GetDetailFolderQueryHandler : IRequestHandler<GetDetailFolderQuery, FolderDto>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public GetDetailFolderQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public async Task<FolderDto> Handle(GetDetailFolderQuery request, CancellationToken cancellationToken)
        {
            var folder = await dbContext.FindByIdAsync<Folder>(request.id);
            return mapper.Map<FolderDto>(folder);
        }
    }
}
