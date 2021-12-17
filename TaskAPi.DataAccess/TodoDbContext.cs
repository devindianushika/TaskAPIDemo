using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TaskAPI.Models;

namespace TaskAPi.DataAccess
{
   public class TodoDbContext:DbContext
    {

        DbSet<Todo> Todos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server =Desktop-33mepoj;Database =TodoDB; User Id =; Password=";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
