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

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public ActionResult<ICollection<AuthorDTO>> GetAllAuthors()
        {
           var authorlist =  _authorService.GetAllAuthors();
            var authordto =new List<AuthorDTO>();
            foreach(var author in authorlist)
            {
                authordto.Add(new AuthorDTO
                {
                Id = author.Id,
                FullName = author.FullName,
                Address = $"{author.Address},{author.Street},{author.City}"
                });
            }

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
               
            return Ok(author);
        }

        



    }
}
