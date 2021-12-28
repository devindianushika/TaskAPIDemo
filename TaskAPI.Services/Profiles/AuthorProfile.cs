using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TaskAPI.Models;
using TaskAPI.Services.ViewModels;

namespace TaskAPI.Services.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorDTO>() // if destination has any attribute name does not match with source's attribute name map them using "formemeber" 
                .ForMember(desti => desti.Address,
                option => option.MapFrom(src => $"{src.Address}{src.Street},{src.City}"));

            CreateMap<CreateAuthorDTO, Author>();
        }
    }
}
