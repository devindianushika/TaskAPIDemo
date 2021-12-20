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
        

        [HttpGet("{id?}")]
        public IActionResult GetTodos(int ? id)
        {
            var listOfTodos = _itodoservice.AllTodos();
            if (id is null)
                return Ok(listOfTodos);

            var task = listOfTodos.Where(t => t.id == id);
           
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
