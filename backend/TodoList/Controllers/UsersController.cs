using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoList.Entities;
using TodoList.Models;
using Microsoft.EntityFrameworkCore;

namespace TodoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly TodoContext _context;

        public UsersController(TodoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _context.Users.AsNoTracking().ToList();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public User GetUser(int id)
        {
            var user = _context.Users.Find(id);

            return user;
        }

        [HttpPost]
        public IActionResult PostUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok();
        }

      
    }
}
