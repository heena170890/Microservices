using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserServices.Model
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Age=29,
                    Name = "Heena",
                    Email = "heena@gmail.com"
                },
                new User
                {
                    Id = 2,
                    Age = 29,
                    Name = "Anshika",
                    Email = "anshika@gmail.com"
                });
        }
    }
}
