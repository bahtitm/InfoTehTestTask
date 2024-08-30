using Application.Features.AppFiles.Dtos;

namespace Application.Features.AppFiles.Commands.UpdateAppFile
{
    public class UpdateAppileCommand : IRequest<AppFileDto>
    {
        public uint Id { get; set; }
    }
}
