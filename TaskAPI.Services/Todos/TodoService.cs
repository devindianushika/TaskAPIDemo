using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Models;
namespace TaskAPI.Services.Todos
{
    public class TodoServic
    {

       public List<Todo> AllTodos()
        {
            var todolist = new List<Todo>();
            var todo1 = new Todo
            {
                id = 1,
                Title = "Morning Exercising",
                Description = " Physical health relared task",
                Created = DateTime.Now,
                Due = DateTime.Today.AddDays(5),
                Status = TodoStatus.New


            };

            todolist.Add(todo1);
            var todo2 = new Todo
            {
                id = 2,
                Title = "Cycling",
                Description = " Physical health relared task",
                Created = DateTime.Now,
                Due = DateTime.Today.AddDays(5),
                Status = TodoStatus.New


            };

            todolist.Add(todo2);
            return todolist;
        }

    }
}
