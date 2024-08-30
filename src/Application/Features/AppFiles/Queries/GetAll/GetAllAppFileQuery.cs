using Application.Features.AppFiles.Dtos;

namespace Application.Features.AppFiles.Queries.GetAll
{
    public record GetAllAppFileQuery : IRequest<IEnumerable<AppFileDto>>;
}
