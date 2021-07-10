﻿// <auto-generated />
using ConsoleApp3.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleApp3.Migrations
{
    [DbContext(typeof(StudentAppDbContext))]
    partial class StudentAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsoleApp3.Model.Mark", b =>
                {
                    b.Property<string>("MarkId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("M1")
                        .HasColumnType("int");

                    b.Property<int>("M2")
                        .HasColumnType("int");

                    b.Property<int>("M3")
                        .HasColumnType("int");

                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("MarkId");

                    b.HasIndex("StudentId");

                    b.ToTable("MarkList");
                });

            modelBuilder.Entity("ConsoleApp3.Model.Student", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ConsoleApp3.Model.Mark", b =>
                {
                    b.HasOne("ConsoleApp3.Model.Student", null)
                        .WithMany("MarkList")
                        .HasForeignKey("StudentId");
                });
#pragma warning restore 612, 618
        }
    }
}
