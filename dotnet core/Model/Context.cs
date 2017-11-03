using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dotnet_core.Model;

namespace dotnet_core.Model
{
    public class EX5Context : DbContext
    {
        public EX5Context(DbContextOptions<EX5Context> options): base(options)
        {
            
        }
        public DbSet<Category> Category { set; get; }
        public DbSet<ComponentType> ComponentType { set; get; }
        public DbSet<Component> Component { set; get; }
        public DbSet<ESImage> EsImage { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasKey(x => x.CategoryId);

            modelBuilder.Entity<ComponentType>()
                .HasKey(x => x.ComponentTypeId);

            modelBuilder.Entity<tableJoin>()
                .HasKey(x => new { x.CategoryId, x.ComponentTypeId });
            modelBuilder.Entity<tableJoin>()
                .HasOne(x => x.Category)
                .WithMany(m => m.ComponentTypes)
                .HasForeignKey(x => x.CategoryId);
            modelBuilder.Entity<tableJoin>()
                .HasOne(x => x.ComponentType)
                .WithMany(e => e.Categories)
                .HasForeignKey(x => x.ComponentTypeId);
        }

        public DbSet<dotnet_core.Model.tableJoin> tableJoin { get; set; }

    }
}
