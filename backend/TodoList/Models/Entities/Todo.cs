using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;
using TodoList.Models.Entities;

namespace TodoList.Entities
{
    public class Todo : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }


        [ForeignKey("UserID")]
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
