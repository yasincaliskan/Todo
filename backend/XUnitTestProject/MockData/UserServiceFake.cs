using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoList.Entities;

namespace XUnitTestProject.MockData
{
    public class UserServiceFake
    {
        private readonly List<User> _userList;

        public UserServiceFake()
        {
            _userList = new List<User>()
            {
                new User(){ Name = "Yasko" },
                new User(){ Name = "Casko" },
                new User(){ Name = "Zusko" },
            };
        }

        public IEnumerable<User> GetAll()
        {
            return _userList;
        }

        public User AddUser(User user)
        {
            _userList.Add(user);
            return user;
        }

        public User GetById(User user)
        {
            return _userList.Where(c => c.ID == user.ID).FirstOrDefault();
        }
    }
}
