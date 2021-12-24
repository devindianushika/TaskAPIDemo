using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public IActionResult CreateNewTask()
        {
           /* var task1 = new Task()
            {
                Name = task.Name,
                Age = task.Age
            };*/
    
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTask()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTask()
        {
            var somethingrong = true;
            if (somethingrong)
            {
                return BadRequest();
            }
            return Ok();
        }

    }
}
