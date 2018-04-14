using System;
using Microsoft.EntityFrameworkCore;

namespace StoreFront.Models
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            :base(options)
        {
        }
        public DbSet<StoreFront.Models.Product> Product { get; set; }
        public DbSet<StoreFront.Models.Image> Image { get; set; }
        public DbSet<StoreFront.Models.Color> Color { get; set; }
    }
}
