using Microsoft.AspNetCore.Mvc;
using opgave.Models;

namespace opgave.Controllers;

public class ParkingController : Controller
{
   
    // GET
    [HttpGet]
    public IActionResult Index()
    {
        ParkingTicketMachine p = new ParkingTicketMachine();


        return View(p);
    }

    [HttpPost]
    public IActionResult Index(ParkingTicketMachine p, IFormCollection form)
    {
        
        
        int coinValue = Convert.ToInt32(form["coin"]);
        p.InsertCoin(coinValue);

        if (!string.IsNullOrEmpty(form["cancel"]))
        {
            ViewBag.info = $"{p.AmountInserted} kr is paid back";
            p = new ParkingTicketMachine();
            return View(p);
        }

        if (!string.IsNullOrEmpty(form["confirm"]))
        {
            ViewBag.info = $"ticket bought for {p.AmountInserted}";
            

            return View("Confirm", p);
        }
        

        // Console.WriteLine(coinValue);
        // ViewBag.AmountInserted =  p.AmountInserted;
        


            return View(p);
    }
}