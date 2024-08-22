namespace Application.Features.Folders.Commands.DeleteFolder
{
    public class DeleteFolderCommandHandler : IRequestHandler<DeleteFolderCommand>
    {
        private readonly IApplicationDbContext dbContext;

        public DeleteFolderCommandHandler(IApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Handle(DeleteFolderCommand request, CancellationToken cancellationToken)
        {
            var folder = await dbContext.FindByIdAsync<Folder>(request.id);
            dbContext.Set<Folder>().Remove(folder);
            await dbContext.SaveChangesAsync();
        }
    }
}
