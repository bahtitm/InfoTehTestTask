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
                new FileExtension { Id=1,  Icon="1", Type="pdf"    },
                new FileExtension { Id=2,Icon="2", Type="xsls"  },
                new FileExtension { Id=3, Icon="3", Type="doc"   },

                    };

                await appDbContext.Set<FileExtension>().AddRangeAsync(subscriptions);




            }
            await appDbContext.SaveChangesAsync();

        }
    }
}
