using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using TodoList.Controllers;
using TodoList.Entities;
using TodoList.Models;
using TodoList.Models.Repositories;
using Xunit;

namespace XUnitTestProject
{
    public class UserTests
    {
        UserRepository _repository;
        UsersController _controller;

        //public UserTests()
        //{
        //    _repository = new UserRepository();
        //    _controller = new UsersController(_repository);
        //}

        //[Fact]
        //public void Get_All_Users()
        //{
        //    var result = _controller.GetUsers();

        //    Assert.IsType<OkObjectResult>(result);
        //}
    }
}
