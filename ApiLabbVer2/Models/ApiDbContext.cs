using Microsoft.EntityFrameworkCore;
namespace ApiLabbVer2.Models
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Interest> Interests { get; set; }

        public DbSet<Link> Link { get; set; }
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person { Id = 1, Name = "Peter", PhoneNumber = 123456 },
                new Person { Id = 2, Name = "Steve", PhoneNumber = 223456 },
                new Person { Id = 3, Name = "David", PhoneNumber = 323456 },
                new Person { Id = 4, Name = "Rutger", PhoneNumber = 423456 },
                new Person { Id = 5, Name = "Stig", PhoneNumber = 523456 },
                new Person { Id = 6, Name = "Sten", PhoneNumber = 623456 }
            );

            modelBuilder.Entity<Interest>().HasData(
                new Interest { Id = 1, Title = "Gaming", Description = "Spela spel"},
                new Interest { Id = 2, Title = "mat", Description = "äta mat"},
                new Interest { Id = 3, Title = "springa", Description = "springa runt"},
                new Interest { Id = 4, Title = "sova", Description = "bara älskar sova"},
                new Interest { Id = 5, Title = "flyga", Description = "flyga runt och sådant"},
                new Interest { Id = 6, Title = "Läsa", Description = "läsa böcker och sånt"}
            );

            modelBuilder.Entity<Link>().HasData(
                new Link { Id = 1, }


            );
            
        }
    }
}
