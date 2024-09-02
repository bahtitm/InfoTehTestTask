using Application.Features.AppFiles.Dtos;

namespace Application.Features.AppFiles.Commands.CreateFolderFile
{
    internal class CreateAppFileCommandHandler : IRequestHandler<CreateAppFileCommand, AppFileDto>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public CreateAppFileCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<AppFileDto> Handle(CreateAppFileCommand request, CancellationToken cancellationToken)
        {
            var folderFile = mapper.Map<AppFile>(request);
            using (var memoryStream = new MemoryStream())
            {
                request.File.OpenReadStream().CopyTo(memoryStream);
                folderFile.File= memoryStream.ToArray();
            }
            await dbContext.AddAsync(folderFile);
            await dbContext.SaveChangesAsync();
            return mapper.Map<AppFileDto>(folderFile);
        }
    }
}
