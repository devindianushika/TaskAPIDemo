using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.Services.Authors;
using TaskAPI.Services.ViewModels;

namespace TaskAPI.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService ;
        private readonly IMapper _imapper;

        public AuthorController(IAuthorService authorService, IMapper imapper)
        {
            _authorService = authorService;
            _imapper = imapper;
        }

        [HttpGet]
        public ActionResult<ICollection<AuthorDTO>> GetAllAuthors(string job,string search)
        {
           var authorlist =  _authorService.GetAllAuthors(job,search);
           var authordto = _imapper.Map<ICollection<AuthorDTO>>(authorlist); //<destination>(source)

            return Ok(authordto);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id)
        {
            var author = _authorService.GetAuthor(id);

            if (author is null)
            {
                return NotFound();
            }

            var MappedAuthordto = _imapper.Map<AuthorDTO>(author);
            return Ok(MappedAuthordto);
        }
        [HttpPost]
        public ActionResult<AuthorDTO> CreateAuthors(CreateAuthorDTO author)
        {
            var MappedAuthor = _imapper.Map<Author>(author);
            var createdauthor = _authorService.AddAuthor(MappedAuthor);
            var returnAuthor = _imapper.Map<AuthorDTO>(createdauthor);
          
            return Ok(returnAuthor);
        }

       


    }
}
