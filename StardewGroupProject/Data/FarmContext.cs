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
