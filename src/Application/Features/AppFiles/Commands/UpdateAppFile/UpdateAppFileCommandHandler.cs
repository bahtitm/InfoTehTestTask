using Application.Features.AppFiles.Dtos;

namespace Application.Features.AppFiles.Commands.UpdateAppFile
{
    internal class UpdateAppFileCommandHandler : IRequestHandler<UpdateAppFileCommand, AppFileDto>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public UpdateAppFileCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<AppFileDto> Handle(UpdateAppFileCommand request, CancellationToken cancellationToken)
        {
            var folderFile = await dbContext.FindByIdAsync<AppFile>(request.Id);
            mapper.Map(request, folderFile);
            await dbContext.SaveChangesAsync();
            return mapper.Map<AppFileDto>(folderFile);
        }
    }
}
