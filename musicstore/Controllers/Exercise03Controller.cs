using Microsoft.AspNetCore.Mvc;
using musicstore.Models;

namespace musicstore.Controllers;

public class Exercise03Controller : Controller
{
    // GET
    public IActionResult Index()
    {
        MusicCD cd = new MusicCD("Prince", "Smoke on the waters", 150m, 1958);
        Track t1 = new Track("john", "beatles", "3:20");
        Track t2 = new Track("hey Jude", "Beatles", "2:50");
        Track t3 = new Track("Som fluer", "The minds of 99", "3:47");
        
        cd.AddTrack(t1);
        cd.AddTrack(t2);
        cd.AddTrack(t3);
        
        return View(cd);
    }
}