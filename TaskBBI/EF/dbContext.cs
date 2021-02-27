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
            
        }
        public DbSet<ApplicationPackage> ApplicationPackage { get; set; }
        public DbSet<PlaceOfResidence> PlaceOfResidence { get; set; }
        public DbSet<Application> Application { get; set; }


    }
}
