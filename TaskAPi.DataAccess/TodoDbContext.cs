using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TaskAPI.Models;

namespace TaskAPi.DataAccess
    {
   public class TodoDbContext:DbContext
    {
        
        public DbSet<Todo>Todos { get; set; }
        public DbSet<Author> Authors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=desktop-33mepoj;Initial Catalog=TodoDB;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[] { 
            
            new Author{Id = 1, FullName = "James William", Address= "12/7", Street= "street1" ,City ="Colombo", Jobrole="Developer" },
            new Author{Id = 2, FullName = "Merry Diyas",Address= "20", Street= "street2" ,City ="Colombo", Jobrole="QA"},
            new Author{Id = 3, FullName = "Stein Martin",Address= "52/1", Street= "street3" ,City ="Kandy",Jobrole="Developer"}
            });

            modelBuilder.Entity<Todo>().HasData(new Todo[]
            {
                new Todo{ id = 1,
                Title = "Morning Exercising",
                Description = " Physical health relared task from DB",
                Created = DateTime.Now,
                Due = DateTime.Today.AddDays(5),
                Status = TodoStatus.New,
                Authorid = 1 },

                new Todo{ id = 2,
                Title = "Watch television",
                Description = " test from db",
                Created = DateTime.Now,
                Due = DateTime.Today.AddDays(5),
                Status = TodoStatus.New,
                Authorid = 3 },

            });
        }
    }
}
