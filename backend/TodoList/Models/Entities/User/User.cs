using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models.Entities;

namespace TodoList.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Todo> TodoList { get; set; }

    }
}
