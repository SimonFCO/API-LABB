using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;
namespace ApiLabbVer2.Models
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }
        public DbSet<Interest> Interests { get; set; }

        public DbSet<Link> Link { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonInterest> PersonInterests { get; set; }

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

            modelBuilder.Entity<PersonInterest>().HasData(
                new PersonInterest { Id = 1, PersonId = 1, Interestid = 1},
                new PersonInterest { Id = 2, PersonId = 1, Interestid = 2},

                new PersonInterest { Id = 3, PersonId = 2, Interestid = 3},
                new PersonInterest { Id = 4, PersonId = 2, Interestid = 6},

                new PersonInterest { Id = 5, PersonId = 3, Interestid = 5},

                new PersonInterest { Id = 6, PersonId = 4, Interestid = 2},
                new PersonInterest { Id = 7, PersonId = 4, Interestid = 3},

                new PersonInterest { Id = 8, PersonId = 5, Interestid = 1},
                new PersonInterest { Id = 9, PersonId = 5, Interestid = 4},

                new PersonInterest { Id = 10, PersonId = 6, Interestid = 4}
            );

            modelBuilder.Entity<Link>().HasData(
                new Link { Id = 1, PersonId = 1, Interestid = 1, Url = "https://www.aftonbladet.se/"},

                new Link { Id = 3, PersonId = 2, Interestid = 3, Url = "https://www.youtube.com/" },

                new Link { Id = 5, PersonId = 3, Interestid = 5, Url = "https://visitvarberg.se/uppleva/subbe-fyr" },

                new Link { Id = 6, PersonId = 4, Interestid = 2, Url = "https://TotallyARealLink.Real"},

                new Link { Id = 8, PersonId = 5, Interestid = 1, Url = "https://YEYEYEYEYE.com"},

                new Link { Id = 10, PersonId = 6, Interestid = 4, Url = "https://halloDer"}
            );
            
        }
    }
}
