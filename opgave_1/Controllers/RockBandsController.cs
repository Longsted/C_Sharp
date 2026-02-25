using Microsoft.AspNetCore.Mvc;

namespace opgave_1.Controllers;

public class RockBandsController : Controller
{
    // GET
    public IActionResult Bands()
    {
        string[] favoriteBands = new[]
        {
            "Led Zeppelin", "The Beatles", "Pink floyd", "The Jimi Hendrix Experience", "Van Halen",
            "Queen", "The Eagles", "U2", "Bob Marley and the Wailers"
        };
        ;
        ViewBag.bands = favoriteBands;
        
        return View();
    }
}