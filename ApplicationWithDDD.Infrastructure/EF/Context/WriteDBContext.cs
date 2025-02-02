

using Microsoft.EntityFrameworkCore;

namespace ApplicationWithDDD.Infrastructure.EF.Context
{
    internal sealed class WriteDBContext : DbContext
    {
        public WriteDBContext(DbContextOptions<WriteDBContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
