using System;
using System.Collections.Generic;
using System.Text;
using TaskAPI.Models;

namespace TaskAPI.Services.ViewModels
{
    public class CreateTodoDTO
    {
          
        public string Title { get; set; }
      
        public string Description { get; set; }
     
        public DateTime Created { get; set; }
       
        public DateTime Due { get; set; }
      
        public TodoStatus Status { get; set; }


    }
}
