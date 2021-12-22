using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TaskAPI.Models
{
    public class Author
    {
        public int Id {get; set;}
        [Required]
        [MaxLength(250)]
        public string FullName { get; set; }
        [MaxLength(10)]
        public string Address { get; set; }
        [MaxLength(200)]
        public string Street { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
        public ICollection<Todo> Todos { get; set; } = new List<Todo>();
    }
}
