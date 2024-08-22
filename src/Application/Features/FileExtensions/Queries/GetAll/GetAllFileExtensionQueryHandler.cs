using Application.Features.FileExtensions.Dtos;

namespace Application.Features.FileExtensions.Queries.GetAll
{
    internal class GetAllFileExtensionQueryHandler : IRequestHandler<GetAllFileExtensionQuery, IEnumerable<FileExtensionDto>>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public GetAllFileExtensionQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<FileExtensionDto>> Handle(GetAllFileExtensionQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(dbContext.Set<FileExtension>().ProjectTo<FileExtensionDto>(mapper.ConfigurationProvider));
        }
    }
}
