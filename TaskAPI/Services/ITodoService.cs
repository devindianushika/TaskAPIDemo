using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services
{
    public interface ITodoService
    {
        public List<Todo> AllTodos();
    }
}
