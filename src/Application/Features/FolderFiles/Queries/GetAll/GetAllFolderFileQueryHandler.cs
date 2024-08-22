using Application.Features.FolderFiles.Dtos;

namespace Application.Features.FolderFiles.Queries.GetAll
{
    internal class GetAllFolderFileQueryHandler : IRequestHandler<GetAllFolderFileQuery, IEnumerable<FolderFileDto>>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public GetAllFolderFileQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<FolderFileDto>> Handle(GetAllFolderFileQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(dbContext.Set<FolderFile>().ProjectTo<FolderFileDto>(mapper.ConfigurationProvider));
        }
    }
}
