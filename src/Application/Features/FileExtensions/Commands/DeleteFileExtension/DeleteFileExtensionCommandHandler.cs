namespace Application.Features.FileExtensions.Commands.DeleteFileExtension
{
    internal class DeleteFileExtensionCommandHandler : IRequestHandler<DeleteFileExtensionCommand>
    {
        private readonly IApplicationDbContext dbContext;

        public DeleteFileExtensionCommandHandler(IApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Handle(DeleteFileExtensionCommand request, CancellationToken cancellationToken)
        {
            var fileExtension = await dbContext.FindByIdAsync<FileExtension>(request.id);
            dbContext.Set<FileExtension>().Remove(fileExtension);
            await dbContext.SaveChangesAsync();
        }
    }
}
