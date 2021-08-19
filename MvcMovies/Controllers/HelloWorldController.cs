using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovies.Controllers
{
    public class HelloWorldController : Controller
    {
        //GET: /HelloWorld
        public IActionResult Index()
        {
            ViewData["Title"] = "Hello from the controller";
            return View("/Views/Home/index.cshtml");
        }
        //Get: / Hellow/Welcome
        public string Welcome(string name, int numTimes = 1)
        {
            return $"Welcome to MVC {name}";
        }

        public string WelcomeAgain(string name, int id)
        {
            return $"Welcome to MVC {name}, with {id}";
        }
    }
}
