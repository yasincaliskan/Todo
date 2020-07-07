using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoList.Models;
using Microsoft.EntityFrameworkCore;
using TodoList.Entities;

namespace TodoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoContext _context;

        public TodoController(TodoContext context)
        {
            _context = context;

        }

        [HttpGet]
        public IActionResult GetList()
        {
            var todos = _context.Todos.AsNoTracking().ToList();

            return Ok(todos);
        }

        [HttpGet("{id}")]
        public IActionResult GetTodo(int id)
        {
            var todo = _context.Todos.Find(id);

            return Ok(todo);
        }

        [HttpPost]
        public IActionResult Create(Todo todo)
        {
            var user = _context.Users.Find(todo.UserID);
            todo.User = user;

            user.TodoList.Add(todo);
            _context.Todos.Add(todo);

            _context.SaveChanges();
            return Ok();
        }
    }
}
