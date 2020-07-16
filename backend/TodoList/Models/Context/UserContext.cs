using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Entities;

namespace TodoList.Models.Context
{
    public class UserContext : IdentityDbContext<User>
    {
    }
}
