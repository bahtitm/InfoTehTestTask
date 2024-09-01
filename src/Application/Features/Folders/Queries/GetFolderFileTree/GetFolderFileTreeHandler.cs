using Application.Features.Folders.Dtos;

namespace Application.Features.Folders.Queries.GetFolderFileTree
{
    internal class GetFolderFileTreeHandler : IRequestHandler<GetFolderFileTreeQuery, IEnumerable<TreeDto>>
    {
        private readonly IApplicationDbContext dbContext;
        private readonly IMapper mapper;
        public GetFolderFileTreeHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<TreeDto>> Handle(GetFolderFileTreeQuery request, CancellationToken cancellationToken)
        {
           var t= dbContext.Set<Folder>().ProjectTo<TreeDto>(mapper.ConfigurationProvider).ToList();

            var maxId=t.Max(p => p.Id);
            var folderDto = new List<TreeDto>();
            foreach (var item in t)
            {

                if (item.Files.Count() > 0)
                {
                    foreach (var file in item.Files)
                    {
                        maxId++;
                        folderDto.Add(new TreeDto() { Id=maxId, FileId=file.Id, Name = file.Name, ParentId = item.Id, IsFile = true });

                    }
                }
            }
            t.AddRange(folderDto);
            return await Task.FromResult(t);
        }


    }
}
