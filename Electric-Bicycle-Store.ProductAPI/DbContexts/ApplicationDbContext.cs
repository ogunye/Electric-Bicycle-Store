using Electric_Bicycle_Store.ProductAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Electric_Bicycle_Store.ProductAPI.DbContexts
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
                
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
