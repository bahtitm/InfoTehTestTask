using Application.Features.AppFiles.Dtos;

namespace Application.Features.AppFiles.Commands.UpdateName
{
    public class UpdateAppFileNameCommand : IRequest<AppFileDto>
    {
        public uint Id { get; set; }
        public string? Name { get; set; }

    }
}
