using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskBBI.Models;

namespace TaskBBI.EF
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationPackage>().HasData(new ApplicationPackage[] {
                new ApplicationPackage{Id=1,Title="Basic",Value=5},
                new ApplicationPackage{Id=2,Title="Premium",Value=10},
                new ApplicationPackage{Id=3,Title="Supreme",Value=15},
            });
            builder.Entity<PlaceOfResidence>().HasData(new PlaceOfResidence[] {
                new PlaceOfResidence{Id=1,Title="Sarajevo"},
                new PlaceOfResidence{Id=2,Title="Mostar"},
                new PlaceOfResidence{Id=3,Title="Tuzla"},
                new PlaceOfResidence{Id=4,Title="Srebrenica"},
                new PlaceOfResidence{Id=5,Title="Bratunac"},
            });
        }
        public DbSet<ApplicationPackage> ApplicationPackage { get; set; }
        public DbSet<PlaceOfResidence> PlaceOfResidence { get; set; }
        public DbSet<Application> Application { get; set; }


    }
}
