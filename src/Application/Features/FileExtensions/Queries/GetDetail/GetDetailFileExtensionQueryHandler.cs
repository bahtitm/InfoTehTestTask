using Application.Features.FileExtensions.Dtos;

namespace Application.Features.FileExtensions.Queries.GetDetail
{
    internal class GetDetailFileExtensionQueryHandler : IRequestHandler<GetDetailFileExtensionQuery, FileExtensionDto>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public GetDetailFileExtensionQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public async Task<FileExtensionDto> Handle(GetDetailFileExtensionQuery request, CancellationToken cancellationToken)
        {
            var fileExtension = await dbContext.FindByIdAsync<FileExtension>(request.id);
            return mapper.Map<FileExtensionDto>(fileExtension);
        }
    }
}
