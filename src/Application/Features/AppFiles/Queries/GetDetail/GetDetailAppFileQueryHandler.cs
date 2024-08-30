using Application.Features.AppFiles.Dtos;

namespace Application.Features.AppFiles.Queries.GetDetail
{
    internal class GetDetailAppFileQueryHandler : IRequestHandler<GetDetailAppFileQuery, AppFileDto>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public GetDetailAppFileQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public async Task<AppFileDto> Handle(GetDetailAppFileQuery request, CancellationToken cancellationToken)
        {
            var FolderFile = await dbContext.FindByIdAsync<AppFile>(request.id);
            return mapper.Map<AppFileDto>(FolderFile);
        }
    }
}
