using System;
using System.Collections.Generic;
using System.Text;
using TaskAPI.Models;

namespace TaskAPI.Services.Authors
{
    public interface IAuthorService
    {
       List<Author> GetAllAuthors();
       Author GetAuthor(int id);

        List<Author> GetAllAuthors(string job,string search);


    }
}
