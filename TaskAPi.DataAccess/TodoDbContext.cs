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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=desktop-33mepoj;Initial Catalog=TodoDB;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData(new Todo
            {
                id = 1,
                Title = "Morning Exercising",
                Description = " Physical health relared task from DB",
                Created = DateTime.Now,
                Due = DateTime.Today.AddDays(5),
                Status = TodoStatus.New
            });
        }
    }
}
