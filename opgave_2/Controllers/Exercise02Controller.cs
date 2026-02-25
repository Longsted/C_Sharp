using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Mvc;
using opgave_2.Models;
namespace opgave_2.Controllers;

public class Exercise02Controller : Controller
{
    // GET
    public IActionResult Index()
    {
        Person p1 = new Person("John", "Marston", "Beechers hope", "8600", "Blackwater");
        Person p2 = new Person("Anders", "And", "NoKnow", "Rap", "Andeby");
        p1.AddPhone("098765678");
        p2.AddPhone("1234567");
        Person[]personer = new []{p1, p2};
        return View(personer);
    }
}