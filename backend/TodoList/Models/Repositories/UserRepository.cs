using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Entities;

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
            var _user = _context.Users.Find(user.Name);
            if(_user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Register(User user)
        {
            if (_context.Users.Find(user.ID) != null)
            {
                //This name already exists! (throw exception)            
            }
            else
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }
        }


    }
}
