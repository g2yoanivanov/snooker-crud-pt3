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
<<<<<<< HEAD
        {

        }

        public SnookerCRUDDbContext(DbContextOptions options) : base(options)
        {

        }   
=======
        {

        }

        public SnookerCRUDDbContext(DbContextOptions options) : base(options)
        {

        }
>>>>>>> 930b273d2c98a64c5c3c6a23a778d25ac414e5cc

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //Yoan's connection string
<<<<<<< HEAD
                //optionsBuilder.UseSqlServer(@"Server=DESKTOP-HB55C5B;Database=SnookerCRUDDb;Trusted_Connection=True;");
=======
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-HB55C5B;Database=SnookerCRUDDb;Trusted_Connection=True;");
>>>>>>> 930b273d2c98a64c5c3c6a23a778d25ac414e5cc
                
                //Victor's connection string
                //optionsBuilder.UseSqlServer(@"Server=DESKTOP-54NFRM2\SQLEXPRESS;Database=SnookerCRUDDb;Trusted_Connection=True;");
            }
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
    }
}
