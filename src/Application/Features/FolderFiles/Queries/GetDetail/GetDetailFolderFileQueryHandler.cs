using Application.Features.FolderFiles.Dtos;

namespace Application.Features.FolderFiles.Queries.GetDetail
{
    internal class GetDetailFolderFileQueryHandler : IRequestHandler<GetDetailFolderFileQuery, FolderFileDto>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public GetDetailFolderFileQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public async Task<FolderFileDto> Handle(GetDetailFolderFileQuery request, CancellationToken cancellationToken)
        {
            var FolderFile = await dbContext.FindByIdAsync<FolderFile>(request.id);
            return mapper.Map<FolderFileDto>(FolderFile);
        }
    }
}
