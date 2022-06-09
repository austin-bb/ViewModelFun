using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
      string msg = "This is a string";
      return View("Index", msg);
    }

    [HttpGet("numbers")]
    public IActionResult Numbers()
    {
      int[] numbers = new int[]
      {
        2, 4, 6, 8, 10, 12
      };
      return View("Numbers", numbers);
    }

    [HttpGet("users")]
    public IActionResult Users()
    {
      List<User> users = new List<User>();
      {
        users.Add(new User("Moose", "Philipps"));
        users.Add(new User("Goose", "McGee"));
        users.Add(new User("Horse", "Moore"));
        users.Add(new User("Kangaroo", "Jackson"));
        users.Add(new User("Cat", "Black"));
      };
      return View("Users", users);
    }

    [HttpGet("user")]
    public IActionResult GetUser()
    {
      User moose = new User("Moose", "Philipps");
      return View("User", moose);
    }
}
