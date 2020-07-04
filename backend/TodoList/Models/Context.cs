using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Entities;

namespace TodoList.Models
{
    public class Context : DbContext
    {
       
        public DbSet<User> Users { get; set; }
        public DbSet<Todo> Todos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-Q22PP2J;database=TodoListDB;trusted_connection=true;");
        }
    }
}
