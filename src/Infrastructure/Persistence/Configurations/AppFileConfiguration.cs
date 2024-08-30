

using Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    internal class AppFileConfiguration : IEntityTypeConfiguration<AppFile>
    {
        public void Configure(EntityTypeBuilder<AppFile> builder)
        {

        }
    }
}
