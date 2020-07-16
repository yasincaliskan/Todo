using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Entities;

namespace TodoList.Models
{
    public class TodoContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Todo> Todos { get; set; }

        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>()
                .HasOne<User>(c => c.User)
                .WithMany(c => c.TodoList)
                .HasForeignKey(c => c.UserID);
        }
    }
}
