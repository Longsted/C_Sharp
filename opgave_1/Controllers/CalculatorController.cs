using Microsoft.AspNetCore.Mvc;

namespace opgave_1.Controllers;

public class CalculatorController : Controller
{
    // GET
    [HttpGet]
    public IActionResult TimeCalculator()
    {
        return View();
    }

    [HttpPost]
    public ActionResult TimeCalculator(IFormCollection formCollection)
    {
        int hours = Convert.ToInt32(formCollection["hours"]);
        int minutes = Convert.ToInt32(formCollection["minutes"]);
        int seconds = Convert.ToInt32(formCollection["seconds"]);

        TimeSpan ts = new TimeSpan(0, hours, minutes, seconds);

        double total = ts.TotalSeconds;

        ViewBag.Hours = hours;
        ViewBag.Minutes = minutes;
        ViewBag.Seconds = seconds;

        ViewBag.Total = total;
        return View("TimeCalculatorResult");
    }
}