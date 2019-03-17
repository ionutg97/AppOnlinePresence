using Core.Entities;
using Microsoft.EntityFrameworkCore;


namespace Data
{
    public sealed class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            //Database.Migrate();
        }
        //asta e un tabel din baza ta de date, users, fiecare rand fiind o entitate user
        //public DbSet<User> Users { get; set; }

        public DbSet<Student> Students { get; set; }

        //public DbSet<GameLevel> GameLevels { get; set; }
    }
}