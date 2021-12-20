using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskAPi.DataAccess;
using TaskAPI.Models;

namespace TaskAPI.Services.Authors
{
    public class AuthorService:IAuthorService
    {
        private readonly TodoDbContext _todoDbContext = new TodoDbContext();
        
        public List<Author> GetAllAuthors()
        {
           return _todoDbContext.Authors.ToList();
        }
        public Author GetAuthor(int id)
        {
            return _todoDbContext.Authors.Where(a => a.Id == id).FirstOrDefault();
        }

    }
}
