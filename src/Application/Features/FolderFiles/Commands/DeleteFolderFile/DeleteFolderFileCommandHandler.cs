namespace Application.Features.FolderFiles.Commands.DeleteFolderFile
{
    internal class DeleteFolderFileCommandHandler : IRequestHandler<DeleteFolderFileCommand>
    {
        private readonly IApplicationDbContext dbContext;

        public DeleteFolderFileCommandHandler(IApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Handle(DeleteFolderFileCommand request, CancellationToken cancellationToken)
        {
            var folderFile = await dbContext.FindByIdAsync<FolderFile>(request.id);
            dbContext.Set<FolderFile>().Remove(folderFile);
            await dbContext.SaveChangesAsync();
        }
    }
}
