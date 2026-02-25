using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace opgave.Controllers;

public class Exercise01Controller : Controller
{
    // GET
    public IActionResult Index()
    {
        List<SelectListItem> countries = new List<SelectListItem>();
        countries.Add(new SelectListItem {Text = "China",Value ="CN"});
        countries.Add(new SelectListItem {Text = "Denmark",Value ="DK"});
        countries.Add(new SelectListItem {Text = "Germany",Value ="DE"});
        return View();
    }
}