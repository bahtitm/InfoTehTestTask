namespace Application.Features.AppFiles.Queries.DownloadFile
{
    public class DownloadFileCommandHandler : IRequestHandler<DownloadFileCommand, (byte[] bytes, string documentName)>
    {
        readonly IApplicationDbContext dbContext;
       
        public DownloadFileCommandHandler(IApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
          
        }

        public async Task<(byte[] bytes, string documentName)> Handle(DownloadFileCommand request, CancellationToken cancellationToken)
        {
            var appFile = await dbContext.Set<AppFile>().FirstOrDefaultAsync(p => p.Id == request.Id, cancellationToken);

            var fileName = appFile.Name + "." + appFile.FileExtension.Type;
            return (appFile.File, fileName);
        }
    }
}
