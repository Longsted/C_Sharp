using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Layout.Models;

namespace Layout.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Sale()
    {
        return View();
    }

    public IActionResult MoreSales()
    {
        return View();
    }

    public IActionResult Buy()
    {
        return View();
    }

    public IActionResult BuyAndSell()
    {
        return View();
    }
}