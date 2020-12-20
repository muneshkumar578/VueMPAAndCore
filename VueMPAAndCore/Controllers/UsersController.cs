using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VueMPAAndCore.Models;

namespace VueMPAAndCore.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetUsers()
        {
            var users = new List<User>
            {
                new User{ Name = "User-1", Email = "user1@mailinator.com"},
                new User{ Name = "User-2", Email = "user2@mailinator.com"}
            };
            return Json(users);
        }
    }
}