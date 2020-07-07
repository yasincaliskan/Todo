using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Entities;

namespace TodoList.Models.Repositories
{
    public class TodoRepository
    {
        private readonly TodoContext _context;
        public TodoRepository(TodoContext context)
        {
            _context = context;
        }
        public List<Todo> GetList()
        {
            return _context.Todos.ToList();
        }

        public Todo GetOne(int id)
        {
            return _context.Todos.Find(id);
        }

        public Todo Create(Todo todo)
        {
            var user = _context.Users.Find(todo.UserID);
            user.TodoList.Add(todo);

            todo.User = user;

            _context.Todos.Add(todo);
            _context.SaveChanges();

            return todo;
        }
    }
}
