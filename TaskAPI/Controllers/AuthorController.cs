using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public ActionResult<ICollection<AuthorDTO>> GetAllAuthors()
        {
           var authorlist =  _authorService.GetAllAuthors();
           var authordto = _imapper.Map<ICollection<AuthorDTO>>(authorlist);

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

        



    }
}
