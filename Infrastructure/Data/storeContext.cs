using Core.Entities;

using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data
{
    public class storeContext:DbContext
    {
        public storeContext(DbContextOptions<storeContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
