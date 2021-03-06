﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Entities;
using TodoList.Models.Context;

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

        public List<Todo> GetFiltered(bool status)
        {
            return _context.Todos.Where(c => c.IsDone == status).ToList();
        }


        public Todo GetOne(int id)
        {
            return _context.Todos.Find(id);
        }

        public Todo Create(Todo todo)
        {
            var user = _context.Users.Find(todo.UserID);

            todo.User = user;
            todo.UserID = 1;

            _context.Todos.Add(todo);
            _context.SaveChanges();

            return todo;
        }

        public Todo Update(int id, Todo todo)
        {
            var updatedTodo = _context.Todos.Find(id);

            updatedTodo.ID = todo.ID;
            updatedTodo.Title = todo.Title;
            updatedTodo.Description = todo.Description;
            updatedTodo.IsDone = todo.IsDone;
            updatedTodo.UserID = todo.UserID;
            updatedTodo.User = todo.User;

            _context.SaveChanges();
            return updatedTodo;
        }

    }
}
