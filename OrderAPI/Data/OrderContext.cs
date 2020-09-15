using Microsoft.EntityFrameworkCore;
using OrderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Data
{
    public class OrderContext : DbContext
    {
        DbSet<Order> Order { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = OrderService; Trusted_Connection = True; ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order>().Property(h => h.HandedIn).HasDefaultValue(null);
            modelBuilder.Entity<Order>().Property(l => l.Late).HasDefaultValue(false);
            modelBuilder.Entity<Order>().Property(d => d.DaysLate).HasDefaultValue(0);
        }
    }
}
