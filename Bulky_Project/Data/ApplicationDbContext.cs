using Bulky_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky_Project.Data
{
    public class ApplicationDbContext:DbContext
    {
       // internal readonly object categories;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }
        public DbSet<Categories> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().HasData(
                new Categories { CategoryId = 1, Name = "Action", OrderDisplay = 1 },
                new Categories { CategoryId = 2, Name = "Clothes", OrderDisplay = 2 },
                new Categories { CategoryId = 3, Name = "Jeans", OrderDisplay = 3 },
                new Categories { CategoryId = 4, Name = "Shirts", OrderDisplay = 4 },
                new Categories { CategoryId = 5, Name = "Shoes", OrderDisplay = 5 },
                new Categories { CategoryId = 6, Name = "Hudies", OrderDisplay = 6 }
                );
        }
    }
}
