using Bulky_RazorWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky_RazorWeb.Data
{
        public class ApplicationDbContext : DbContext
        {
            //internal readonly object categories;

            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {

            }
            public DbSet<Category> Categories { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Category>().HasData(
                    new Category { CategoryId = 1, Name = "Jordens AirForce", OrderDisplay = 1 },
                    new Category { CategoryId = 2, Name = "Clothes", OrderDisplay = 2 },
                    new Category { CategoryId = 3, Name = "Jeans", OrderDisplay = 3 }
                  
                    );
            }
        }
    }

