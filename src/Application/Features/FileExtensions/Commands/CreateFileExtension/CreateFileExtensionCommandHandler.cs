using Application.Features.FileExtensions.Dtos;

namespace Application.Features.FileExtensions.Commands.CreateFileExtension
{
    internal class CreateFileExtensionCommandHandler : IRequestHandler<CreateFileExtensionCommand, FileExtensionDto>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public CreateFileExtensionCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<FileExtensionDto> Handle(CreateFileExtensionCommand request, CancellationToken cancellationToken)
        {
            var fileExtension = mapper.Map<FileExtension>(request);
            await dbContext.AddAsync(fileExtension);
            await dbContext.SaveChangesAsync();
            return mapper.Map<FileExtensionDto>(fileExtension);
        }
    }
}
