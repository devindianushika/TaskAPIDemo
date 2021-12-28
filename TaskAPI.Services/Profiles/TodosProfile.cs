using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskAPI.Models;
using TaskAPI.Services.ViewModels;

namespace TaskAPI.Services.Profiles
{
   public class TodosProfile : Profile
    {
        public TodosProfile()
        {
            CreateMap<Todo, TodoDTO>();
            CreateMap<CreateTodoDTO, Todo>();
        }
      
    }
}
