using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using musicstore.Models;

namespace musicstore.Controllers;

public class Exercise01 : Controller
{
    // GET
    public IActionResult Index()
    {
        
        Book p1 = new Book("A Hard Day's Write: The Stories Behind Every Beatles Song",150.00m, "Steve Turner",
            "It Books",2005, "00608444094");
        p1.ImageUrl = "/images/A hard day.jpg";
        
        MusicCD p2 = new MusicCD("Abbey Road (Remastered)", 128.00m, "Beatles", "EMi", 2009);
        p2.ImageUrl = "/images/abbey road.jpg";
        string[] tracks = new[]
        {
            "Come Together", "Something", "Maxwell's Silver Hammer", "Oh! Darling", "Octopus' Garden",
            "I Want You (She's So Heavy)",
            "Here Comes The Sun", "Because", "You Never Give Me Your Money", "Sun King", "Mean Mr.Mustard",
            "Polythene Pam",
            "She Came In Through The Bathroom Window", "Golden Slumbers", "Carry That Weight", "The End", "Her Majesty"
        };
        foreach (var track in tracks)
        {
            p2.AddTrack(track);
        }
        Product[] products ={p1,p2};
        
        return View(products);
    }
}