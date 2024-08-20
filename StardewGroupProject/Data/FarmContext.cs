using Microsoft.EntityFrameworkCore;
using StardewGroupProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StardewGroupProject.Data
{
    public class FarmContext : DbContext
    {
        public FarmContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Farm>()
                .HasMany(f => f.Rooms)
                .WithOne()
                .OnDelete(DeleteBehavior.ClientCascade);

            // Room has many Bundles, when a Room is deleted, Bundles should also be deleted.
            modelBuilder
                .Entity<Room>()
                .HasMany(r => r.Bundles)
                .WithOne()
                .OnDelete(DeleteBehavior.ClientCascade);

            // Bundle has many Items, when a Bundle is deleted, Items should also be deleted.
            modelBuilder
                .Entity<Bundle>()
                .HasMany(b => b.Items)
                .WithOne()
                .OnDelete(DeleteBehavior.ClientCascade);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StardewGroupProject;Trusted_Connection=True;");
        }
        public DbSet<Farm> Farms { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Bundle> Bundles { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
