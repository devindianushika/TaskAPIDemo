using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.Services.Todos;
using TaskAPI.Services.ViewModels;

namespace TaskAPI.Controllers
{
    [Route("api/authors/{authorid}/tasks")]
    [ApiController]

    
    public class TasksController : ControllerBase
    {
        private readonly ITodoService _itodoservice;
        private readonly IMapper _imapper;

            public TasksController(ITodoService itodoservice,IMapper imapper)
        {
            _itodoservice = itodoservice;
            _imapper = imapper;
        }


        [HttpGet]
        public ActionResult <ICollection<TodoDTO>> GetAllTodos(int authorid)
        {
            var todos =  _itodoservice.AllTodos(authorid);
            var mappedTodos = _imapper.Map<ICollection<TodoDTO>>(todos);
            return Ok(mappedTodos);
        }
           
        [HttpGet("{id}")]
        public IActionResult GetTodo(int authorid, int id)
        {
            var task = _itodoservice.getTodo(authorid, id);
            if (task is null)
            {
                return NotFound();
            }
                
           var mappedTask = _imapper.Map<TodoDTO>(task);
            return Ok(mappedTask);
        }       

       
        [HttpPost]
        public ActionResult<TodoDTO> CreateNewTask(int authorid, CreateTodoDTO todo)
        {
            var mappedTodo = _imapper.Map<Todo>(todo);
            var createdtodo = _itodoservice.addTodo(authorid, mappedTodo);
            var returnTodo = _imapper.Map<TodoDTO>(createdtodo);

            return Ok(returnTodo);
        }

        [HttpPut("{taskid}")]
        public ActionResult<TodoDTO> UpdateTask(int authorid, int taskid, UpdateTodoDTO todo)
        {
            var updatingtodo = _itodoservice.getTodo(authorid, taskid);
            if(updatingtodo is null)
            {
                return NotFound();
            }
            var mappedtodo =  _imapper.Map(todo,updatingtodo);
            var updatedtodo = _itodoservice.updateTodo(mappedtodo);
           
            return Ok(updatedtodo);
        }

        [HttpDelete("{taskid}")]
        public IActionResult DeleteTask(int authorid,int taskid)
        {
            var todo = _itodoservice.getTodo(authorid,taskid);
            if (todo is null)
            {
                return BadRequest();
            }
            var message = _itodoservice.deleteTodo(todo);
            return Ok(message);
        }

    }
}
