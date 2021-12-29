using System;
using System.Collections.Generic;
using System.Text;
using TaskAPI.Models;
using TaskAPi.DataAccess;
using System.Linq;

namespace TaskAPI.Services.Todos
{
    public class TodoSqlService : ITodoService
    {
        private readonly TodoDbContext _todbcontext = new TodoDbContext();
        
        public List<Todo> AllTodos(int authorid)
        {
            return _todbcontext.Todos.Where(t => t.Authorid == authorid).ToList();
        }
        public Todo getTodo(int authorid, int id)
        {
            return _todbcontext.Todos.Where(a => a.Authorid == authorid).ToList().FirstOrDefault(t => t.id==id);
           // return _todbcontext.Todos.FirstOrDefault(t => t.id == id && t.Authorid == authorid);
                }

        public Todo addTodo(int authorid, Todo todo)
        {
            todo.Authorid = authorid;
            _todbcontext.Todos.Add(todo);
            _todbcontext.SaveChanges();
            return _todbcontext.Todos.Find(todo.id);
        }

        public Todo updateTodo(Todo todo)
        {
            _todbcontext.SaveChanges();
            return todo;
        }

        public string deleteTodo(Todo todo)
        {
            _todbcontext.Todos.Remove(todo);
            _todbcontext.SaveChanges();
            return ("deleted successfully");
        }

    }
}
