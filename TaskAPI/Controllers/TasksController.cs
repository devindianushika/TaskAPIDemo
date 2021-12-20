using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Services.Todos;
namespace TaskAPI.Controllers
{
    [Route("api/tasks")]
    [ApiController]

    
    public class TasksController : ControllerBase
    {
        private readonly ITodoService _itodoservice;

            public TasksController(ITodoService itodoservice)
        {
            _itodoservice = itodoservice;
        }


        [HttpGet]
        public IActionResult GetAllTodos()
        {
            var todos =  _itodoservice.AllTodos();
            return Ok(todos);
        }
           
            [HttpGet("{id}")]
        public IActionResult GetTodo(int id)
        {
            var task = _itodoservice.getTodo(id);
            if (task is null)
            {
                return NotFound();
            }
                
           
            return Ok(task);
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
