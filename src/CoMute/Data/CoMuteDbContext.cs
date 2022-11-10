using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CoMute.Web.Data
{
    public class CoMuteDbContext : DbContext
    {
            public DbSet<User> Users { get; set; }
            public DbSet<CarPool> CarPools { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["DevConnection"].ConnectionString);
            }
    }
}