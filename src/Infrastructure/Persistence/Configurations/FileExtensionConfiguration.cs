

using Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    internal class FileExtensionConfiguration : IEntityTypeConfiguration<FileExtension>
    {
        public void Configure(EntityTypeBuilder<FileExtension> builder)
        {

        }
    }
}
