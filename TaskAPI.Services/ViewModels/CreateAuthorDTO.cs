using System;
using System.Collections.Generic;
using System.Text;

namespace TaskAPI.Services.ViewModels
{
    public class CreateAuthorDTO
    {
      
        public string FullName { get; set; }
        public string Address { get; set; }
       
        public string Street { get; set; }
       
        public string City { get; set; }
         
        public string Jobrole { get; set; }
        public ICollection<CreateTodoDTO> Todos { get; set; } = new List<CreateTodoDTO>();
    }
}
