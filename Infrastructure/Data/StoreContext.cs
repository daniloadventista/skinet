using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        //nuget microsoft.entityFrameworkCore.Sqllite installed
        //nuget microsoft.entityFrameworkCore.SqlServer installed to
        //microsoft.entityFrameworkCore.SqlServer could do compatibilities issues
        //
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}