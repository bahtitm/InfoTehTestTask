namespace Application.Features.AppFiles.Commands.DeleteAppFile
{
    internal class DeleteAppFileCommandHandler : IRequestHandler<DeleteAppFileCommand>
    {
        private readonly IApplicationDbContext dbContext;

        public DeleteAppFileCommandHandler(IApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Handle(DeleteAppFileCommand request, CancellationToken cancellationToken)
        {
            var folderFile = await dbContext.FindByIdAsync<AppFile>(request.id);
            dbContext.Set<AppFile>().Remove(folderFile);
            await dbContext.SaveChangesAsync();
        }
    }
}
