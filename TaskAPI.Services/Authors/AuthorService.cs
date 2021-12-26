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

        public List<Author> GetAllAuthors(string job,string search)
        {
            if (string.IsNullOrWhiteSpace(job) & string.IsNullOrWhiteSpace(search))
            {
               return this.GetAllAuthors();

            }

            var authorcollection = _todoDbContext.Authors as IQueryable<Author>;// author type Iqueryable akak,use to construct a command
            if (!string.IsNullOrWhiteSpace(job))
            {
                job = job.Trim();
                authorcollection = authorcollection.Where(a => a.Jobrole == job);
            }

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.Trim();
                authorcollection = authorcollection.Where(a => a.FullName.Contains(search) || a.City.Contains(search));
            }

            return authorcollection.ToList(); //to get better performance use data base call at this point only
        }

    }
}
