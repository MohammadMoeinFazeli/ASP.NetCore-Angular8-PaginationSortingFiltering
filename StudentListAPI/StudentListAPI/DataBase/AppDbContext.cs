using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentListAPI.DataBase.Entities;

namespace StudentListAPI.DataBase
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student[]
            {
                new Student {StudentId = 1, Name = "moein", Family = "Fazeli"},
                new Student {StudentId = 2, Name = "omid", Family = "gholami"},
                new Student {StudentId = 3, Name = "sara", Family = "saravi"},
                new Student {StudentId = 4, Name = "fateme", Family = "mosavi"},
                new Student {StudentId = 5, Name = "jodi", Family = "abot"},
                new Student {StudentId = 6, Name = "sobasa", Family = "karaeer"},
                new Student {StudentId = 7, Name = "ahmad", Family = "hoseeini"},
                new Student {StudentId = 8, Name = "mohammad", Family = "bahrami"},
                new Student {StudentId = 9, Name = "saeed", Family = "sadeghi"},
                new Student {StudentId = 10, Name = "sajad", Family = "saheri"},
                new Student {StudentId = 11, Name = "sami", Family = "sarvari"},
                new Student {StudentId = 12, Name = "bano", Family = "mahmodi"},
                new Student {StudentId = 13, Name = "mahdie", Family = "maghsoodi"},
                new Student {StudentId = 14, Name = "shahriar", Family = "asadi"}
            });
        }
    }
}