using Application.Features.AppFiles.Dtos;

namespace Application.Features.AppFiles.Queries.GetDetail
{
    public record GetDetailAppFileQuery(uint id) : IRequest<AppFileDto>;
}
