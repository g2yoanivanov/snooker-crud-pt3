using Microsoft.EntityFrameworkCore;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SnookerCRUDDbContext : DbContext
    {
        public SnookerCRUDDbContext()
        {

        }

        public SnookerCRUDDbContext(DbContextOptions options) : base(options)
        {

        }   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //Yoan's connection string
                //optionsBuilder.UseSqlServer(@"Server=DESKTOP-HB55C5B;Database=SnookerCRUDDb;Trusted_Connection=True;");
                
                //Victor's connection string
                //optionsBuilder.UseSqlServer(@"Server=DESKTOP-54NFRM2\SQLEXPRESS;Database=SnookerCRUDDb;Trusted_Connection=True;");
            }
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
    }
}
