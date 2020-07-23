using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoList.Entities;
using TodoList.Models;
using TodoList.Models.Repositories;

namespace TodoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserRepository _repository;

        public UsersController(UserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult GetUsers()
        {
            var userList = _repository.GetList();
            return Ok(userList);
        }

        [HttpGet("{id}")]
        public User GetUser(int id)
        {
            var user = _repository.GetOne(id);

            return user;
        }

        [HttpPost("register")]
        public ActionResult RegisterUser(User user)
        {
            var newUser = _repository.Register(user);

            return Ok(newUser);
        }

        [HttpGet("login")]
        public ActionResult LoginUser(User user)
        {
            if (_repository.Login(user))
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

    }
}
