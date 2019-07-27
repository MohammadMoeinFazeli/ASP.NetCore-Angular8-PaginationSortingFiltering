﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentListAPI.DataBase;

namespace StudentListAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentListAPI.DataBase.Entities.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Family");

                    b.Property<string>("Name");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Family = "Fazeli",
                            Name = "moein"
                        },
                        new
                        {
                            StudentId = 2,
                            Family = "gholami",
                            Name = "omid"
                        },
                        new
                        {
                            StudentId = 3,
                            Family = "saravi",
                            Name = "sara"
                        },
                        new
                        {
                            StudentId = 4,
                            Family = "mosavi",
                            Name = "fateme"
                        },
                        new
                        {
                            StudentId = 5,
                            Family = "abot",
                            Name = "jodi"
                        },
                        new
                        {
                            StudentId = 6,
                            Family = "karaeer",
                            Name = "sobasa"
                        },
                        new
                        {
                            StudentId = 7,
                            Family = "hoseeini",
                            Name = "ahmad"
                        },
                        new
                        {
                            StudentId = 8,
                            Family = "bahrami",
                            Name = "mohammad"
                        },
                        new
                        {
                            StudentId = 9,
                            Family = "sadeghi",
                            Name = "saeed"
                        },
                        new
                        {
                            StudentId = 10,
                            Family = "saheri",
                            Name = "sajad"
                        },
                        new
                        {
                            StudentId = 11,
                            Family = "sarvari",
                            Name = "sami"
                        },
                        new
                        {
                            StudentId = 12,
                            Family = "mahmodi",
                            Name = "bano"
                        },
                        new
                        {
                            StudentId = 13,
                            Family = "maghsoodi",
                            Name = "mahdie"
                        },
                        new
                        {
                            StudentId = 14,
                            Family = "asadi",
                            Name = "shahriar"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
