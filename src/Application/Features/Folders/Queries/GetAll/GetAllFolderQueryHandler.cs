using Application.Features.Folders.Dtos;

namespace Application.Features.Folders.Queries.GetAll
{
    internal class GetAllFolderQueryHandler : IRequestHandler<GetAllFolderQuery, IEnumerable<FolderDto>>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public GetAllFolderQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<FolderDto>> Handle(GetAllFolderQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(dbContext.Set<Folder>().ProjectTo<FolderDto>(mapper.ConfigurationProvider));
        }
    }
}
