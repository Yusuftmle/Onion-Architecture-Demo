using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Onion.Architecture.Demo.Domain.Entities;

namespace Onion.Architecture.Demo.Persistance.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
             new Product() { Id = Guid.NewGuid(), Name = "ahsap", Value = 15, Quantity = 150 },
             new Product() { Id = Guid.NewGuid(), Name = "metal", Value = 15, Quantity = 2250 },
             new Product() { Id = Guid.NewGuid(), Name = "demir", Value = 15, Quantity = 1000 }

                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
