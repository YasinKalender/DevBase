using DevBase.Entities.ORM.Concerte;
using DevBase.Map.Option;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevBase.DAL.Context
{
    public class ProjectContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=DevBase; integrated security=true");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMapping());
            modelBuilder.ApplyConfiguration(new ProductMapping());


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Category> Category { get; set; }

        public DbSet<Product> Product { get; set; }

    }
}
