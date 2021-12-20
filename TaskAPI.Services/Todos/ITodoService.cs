using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public interface ITodoService
    {
        List<Todo> AllTodos();
        Todo getTodo(int id);
    }
}
