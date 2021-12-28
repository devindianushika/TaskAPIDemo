using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public interface ITodoService
    {
        List<Todo> AllTodos(int authorid);
        Todo getTodo(int authorid, int id);
        Todo addTodo(int id, Todo todo);
    }
}
