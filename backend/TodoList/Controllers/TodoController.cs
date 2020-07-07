using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoList.Models;
using Microsoft.EntityFrameworkCore;
using TodoList.Entities;
using TodoList.Models.Repositories;

namespace TodoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoRepository _repository;

        public TodoController(TodoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var todoList = _repository.GetList();
            return Ok(todoList);
        }

        [HttpGet("completed")]
        public IActionResult GetCompleted()
        {
            var todoList = _repository.GetFiltered(true);
            return Ok(todoList);
        }

        [HttpGet]
        public IActionResult GetUncompleted()
        {
            var todoList = _repository.GetFiltered(false);
            return Ok(todoList);
        }


        [HttpGet("{id}")]
        public IActionResult GetTodo(int id)
        {
            var todo = _repository.GetOne(id);

            return Ok(todo);
        }

        [HttpPost]
        public IActionResult Create(Todo todo)
        {
            return Ok(_repository.Create(todo));
        }

        [HttpGet("/mark-done/{id}")]
        public IActionResult Complete(int id)
        {
            _repository.MarkDone(id);
            return Ok();
        }
    }
}
