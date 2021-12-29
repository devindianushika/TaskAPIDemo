using System;
using System.Collections.Generic;
using System.Text;
using TaskAPI.Models;

namespace TaskAPI.Services.ViewModels
{
    public class TodoDTO
    {
        public int id { get; set; }
       
        public string Title { get; set; }
       
        public string Description { get; set; }
     
        public DateTime Created { get; set; }
       
        public DateTime Due { get; set; }
     
        public string Status { get; set; }
        public int Authorid { get; set; }
       

    }
}
