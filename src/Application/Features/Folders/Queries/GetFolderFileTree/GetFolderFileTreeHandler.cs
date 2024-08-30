using Application.Features.Folders.Dtos;

namespace Application.Features.Folders.Queries.GetFolderFileTree
{
    internal class GetFolderFileTreeHandler : IRequestHandler<GetFolderFileTreeQuery, IEnumerable<TreeDto>>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public GetFolderFileTreeHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<TreeDto>> Handle(GetFolderFileTreeQuery request, CancellationToken cancellationToken)
        {
           var t= dbContext.Set<Folder>().ProjectTo<TreeDto>(mapper.ConfigurationProvider);
            return await Task.FromResult(t);
        }


    }
}
