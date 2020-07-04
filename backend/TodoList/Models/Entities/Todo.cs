using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Entities
{
    public class Todo
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
