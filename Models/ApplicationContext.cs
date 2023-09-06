using Microsoft.EntityFrameworkCore;
using System;

namespace ExtraPoints_Grillino.Models
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Service> Services { get; set; }
        public DbSet<Food> Foods { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
