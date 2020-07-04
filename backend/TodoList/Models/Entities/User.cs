﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Entities
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Todo> TodoList { get; set; }
    }
}
