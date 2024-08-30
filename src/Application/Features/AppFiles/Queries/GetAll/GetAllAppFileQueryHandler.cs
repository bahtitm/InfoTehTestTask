using Application.Features.AppFiles.Dtos;

namespace Application.Features.AppFiles.Queries.GetAll
{
    internal class GetAllAppFileQueryHandler : IRequestHandler<GetAllAppFileQuery, IEnumerable<AppFileDto>>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public GetAllAppFileQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<AppFileDto>> Handle(GetAllAppFileQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(dbContext.Set<AppFile>().ProjectTo<AppFileDto>(mapper.ConfigurationProvider));
        }
    }
}
