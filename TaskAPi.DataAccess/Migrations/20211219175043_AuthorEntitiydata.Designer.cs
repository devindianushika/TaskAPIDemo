﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskAPi.DataAccess;

namespace TaskAPi.DataAccess.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    [Migration("20211219175043_AuthorEntitiydata")]
    partial class AuthorEntitiydata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaskAPI.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "James William"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Merry Diyas"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Stein Martin"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Authorid")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Authorid");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Authorid = 1,
                            Created = new DateTime(2021, 12, 19, 23, 20, 42, 653, DateTimeKind.Local).AddTicks(3671),
                            Description = " Physical health relared task from DB",
                            Due = new DateTime(2021, 12, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            Status = 0,
                            Title = "Morning Exercising"
                        },
                        new
                        {
                            id = 2,
                            Authorid = 3,
                            Created = new DateTime(2021, 12, 19, 23, 20, 42, 654, DateTimeKind.Local).AddTicks(7480),
                            Description = " test from db",
                            Due = new DateTime(2021, 12, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            Status = 0,
                            Title = "Watch television"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.HasOne("TaskAPI.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("Authorid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });
#pragma warning restore 612, 618
        }
    }
}