namespace Application.Features.AppFiles.Queries.DownloadFile
{
    public class DownloadFileCommand : IRequest<(byte[] bytes, string documentName)>
    {
      

        public DownloadFileCommand(uint Id)
        {
            this.Id = Id;
        }

        public uint Id { get; }
    }
}
