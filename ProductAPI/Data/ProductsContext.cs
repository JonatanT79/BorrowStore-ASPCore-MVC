using Microsoft.EntityFrameworkCore;
using ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Data
{
    public class ProductsContext : DbContext
    {
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductCopies> ProductCopies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = ProductService; Trusted_Connection = True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Products>().HasData
            (
                new Products { ID = 1, CopyCount = 3, Name = "Book", Description = "Cool Book" },
                new Products { ID = 2, CopyCount = 3, Name = "BoardGame", Description = "Splendor" },
                new Products { ID = 3, CopyCount = 3, Name = "MacBook", Description = "Good for doing work" },
                new Products { ID = 4, CopyCount = 3, Name = "Guitar", Description = "High quality" }
            );
            modelBuilder.Entity<ProductCopies>().HasData
            (
                new ProductCopies { SerialNumber = "BOOK100", ProductsID = 1 },
                new ProductCopies { SerialNumber = "BOOK200", ProductsID = 1 },
                new ProductCopies { SerialNumber = "BOOK300", ProductsID = 1 },
                new ProductCopies { SerialNumber = "BOARDGAME100", ProductsID = 2 },
                new ProductCopies { SerialNumber = "BOARDGAME200", ProductsID = 2 },
                new ProductCopies { SerialNumber = "BOARDGAME300", ProductsID = 2 },
                new ProductCopies { SerialNumber = "MACBOOK100", ProductsID = 3 },
                new ProductCopies { SerialNumber = "MACBOOK200", ProductsID = 3 },
                new ProductCopies { SerialNumber = "MACBOOK300", ProductsID = 3 },
                new ProductCopies { SerialNumber = "GUITAR100", ProductsID = 4 },
                new ProductCopies { SerialNumber = "GUITAR200", ProductsID = 4 },
                new ProductCopies { SerialNumber = "GUITAR300", ProductsID = 4 }
            );
        }
    }
}
