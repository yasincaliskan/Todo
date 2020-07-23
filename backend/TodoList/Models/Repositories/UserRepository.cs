using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Entities;
using TodoList.Models.Context;

namespace TodoList.Models.Repositories
{
    public class UserRepository
    {
        private readonly TodoContext _context;

        public UserRepository(TodoContext context)
        {
            _context = context;
        }

        public List<User> GetList()
        {
            return _context.Users.ToList();

        }

        public User GetOne(int id)
        {
            return _context.Users.Find(id);
        }

        public bool Login(User user)
        {
            var _user = _context.Users.Find(user.Username);
            if (_user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public User Register(User user)
        {
            if (_context.Users.Find(user.ID) != null)
            {
                //This username already exists! (throw exception) 
                return null;
            }
            else
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return user;
            }
        }
    }
}
