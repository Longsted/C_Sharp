using Layout.Models;
using Microsoft.AspNetCore.Mvc;

namespace Layout.Controllers;

public class PersonController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult VisAlle()
    {
        List<Person> personer = new List<Person>()
        {
            new Person("Niels", "Johnson"),
            new Person("Lasse","Hawaii chick"),
            new Person("Denis","Lettere cool")
            
        };
        return View(personer);
    }

    public IActionResult VisEn()
    {
        return View(new Person("Niels", "Johnson"));
    }
}