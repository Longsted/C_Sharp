using Microsoft.AspNetCore.Mvc;
using musicstore.Models;
namespace musicstore.Controllers;

public class Exercise02Controller : Controller
{
    // GET
    public IActionResult Index()
    {
        Book b1 = new Book("H.C.Andersen", "Kejserens nye klæder", 150m, 2018);
        MusicCD m1 = new MusicCD("Prince", "Smoke on the waters", 150m, 1958);

        Product[] products = new Product[] { b1, m1 };
        
        return View(products);
    }
}