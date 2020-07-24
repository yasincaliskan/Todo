using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models.Entities;
using TodoList.Models.Entities.User;

namespace TodoList.Entities
{
    public class User : BaseEntity
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        //public Role Role { get; set; }
        public ICollection<Todo> TodoList { get; set; }

    }
}
