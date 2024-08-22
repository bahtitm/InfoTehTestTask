

using Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    internal class FolderFileConfiguration : IEntityTypeConfiguration<FolderFile>
    {
        public void Configure(EntityTypeBuilder<FolderFile> builder)
        {

        }
    }
}
