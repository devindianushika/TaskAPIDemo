using System;
using System.Collections.Generic;
using System.Text;
using TaskAPI.Models;
using TaskAPi.DataAccess;
using System.Linq;

namespace TaskAPI.Services
{
    public class TodoSqlService : ITodoService
    {
        private readonly TodoDbContext _todbcontext = new TodoDbContext();
        
        public List<Todo> AllTodos()
        {
            return _todbcontext.Todos.ToList();
        }
    }
}
