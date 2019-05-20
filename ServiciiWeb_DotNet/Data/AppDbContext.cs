using Core.Entities;
using Core.Entities.Attendance;
using Core.Entities.Authentication;
using Core.Entities.Login;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;

namespace Data
{
    public sealed class AppDbContext : DbContext
    {
        public AppDbContext()
            : base()
        {
            //Database.Migrate();
        }
        private const string Connection = @"Server=.\SQLEXPRESS;Database=TIProject;Trusted_Connection=True;ConnectRetryCount=0";
        //asta e un tabel din baza ta de date, users, fiecare rand fiind o entitate user
        //public DbSet<User> Users { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Cours> Courses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<StudiesYear> Years { get; set; }
        public DbSet<Timetable> Timetables { get; set; }
        public DbSet<Laboratory> Laboratories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TeacherAccount> TeacherAccounts { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<ListAttendances> ListAttendances { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
        .HasIndex(u => u.UserName)
        .IsUnique();

            builder.Entity<TeacherAccount>()
         .HasIndex(u => u.TeacherAccountName)
         .IsUnique();

        }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                // .UseLazyLoadingProxies()
                .UseSqlServer(Connection);
        }
    }
}