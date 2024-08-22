using Application.Features.FileExtensions.Dtos;

namespace Application.Features.FileExtensions.Commands.UpdateFileExtension
{
    internal class UpdateFileExtensionCommandHandler : IRequestHandler<UpdateFileExtensionCommand, FileExtensionDto>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public UpdateFileExtensionCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<FileExtensionDto> Handle(UpdateFileExtensionCommand request, CancellationToken cancellationToken)
        {
            var fileExtension = await dbContext.FindByIdAsync<FileExtension>(request.Id);
            mapper.Map(request, fileExtension);
            await dbContext.SaveChangesAsync();
            return mapper.Map<FileExtensionDto>(fileExtension);
        }
    }
}
