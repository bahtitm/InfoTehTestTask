using Domain;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace InfoTehTestTask.Data
{
    public class DatabaseMigrator
    {
        private readonly AppDbContext appDbContext;

        public DatabaseMigrator(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task MigrateAsync()
        {
            await appDbContext.Database.MigrateAsync();
            var anySubscription = appDbContext.Set<FileExtension>().Any();

            if (anySubscription == false)
            {
                var subscriptions = new List<FileExtension>()
               {
                new FileExtension { Id=1,Icon=IconSvg.pdf.Trim(), Type="pdf"    },
                new FileExtension { Id=2,Icon=IconSvg.xlsx.Trim(), Type="xlsx"  },
                new FileExtension { Id=3,Icon=IconSvg.doc.Trim(), Type="doc"   },
                new FileExtension { Id=4,Icon=IconSvg.txt.Trim(), Type="txt"   },

                    };

                await appDbContext.Set<FileExtension>().AddRangeAsync(subscriptions);




            }
            await appDbContext.SaveChangesAsync();

        }
    }
}
