using Microsoft.EntityFrameworkCore;
using OfflineCapable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineCapable.Data
{
    public class InspectionsContext : DbContext
    {
        public DbSet<Inspection> Inspections { get; set; }
        public InspectionsContext(DbContextOptions options)
                : base(options)
        {
            SQLitePCL.Batteries_V2.Init();
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ////defines the physical location of the database
            //string dbPath = Path.Combine(FileSystem.AppDataDirectory, "inspections.db3");

            ////sets the location of the database
            //optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
    }
}
