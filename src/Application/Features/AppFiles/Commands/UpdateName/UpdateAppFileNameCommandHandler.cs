using Application.Features.AppFiles.Dtos;

namespace Application.Features.AppFiles.Commands.UpdateName
{
    internal class UpdateAppFileNameCommandHandler : IRequestHandler<UpdateAppFileNameCommand, AppFileDto>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public UpdateAppFileNameCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<AppFileDto> Handle(UpdateAppFileNameCommand request, CancellationToken cancellationToken)
        {
            var folderFile = await dbContext.FindByIdAsync<AppFile>(request.Id);
            folderFile.Name = request.Name;

            await dbContext.SaveChangesAsync();
            return mapper.Map<AppFileDto>(folderFile);
        }
    }
}
