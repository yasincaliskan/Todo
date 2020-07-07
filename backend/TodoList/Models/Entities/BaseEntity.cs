﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Models.Entities
{
    public class BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public DateTime CreatedTime { get; set; }

        public BaseEntity()
        {
            CreatedTime = DateTime.Now;
        }
    }
}
