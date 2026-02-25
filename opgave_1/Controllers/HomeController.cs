using Microsoft.AspNetCore.Mvc;
using opgave_1.Models;

namespace opgave_1.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        var person = new Person()
        { 
            Name = "peter",
            Age = 25,
            Birthday = new DateTime(2000, 1, 1)
        };
        

        // ViewBag.Name = name;
        // ViewBag.Age = age;
        // ViewBag.Birthday = birthday;
        //
        return View(person);
    }
}