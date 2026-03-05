using System.Diagnostics;
using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using opgave.Infrastructure;
namespace opgave.Controllers;

public class Exercise01Controller : Controller
{
    private List<SelectListItem>? countryList = new List<SelectListItem>();


    // GET
    [HttpGet]
    public IActionResult Index(string countries)
    {
        var json = HttpContext.Session.GetString("countryList");
        if (json == null)
        {
            countryList.Add(new SelectListItem { Text = "China", Value = "CN" });
            countryList.Add(new SelectListItem { Text = "Denmark", Value = "DK" });
            countryList.Add(new SelectListItem { Text = "France", Value = "FR" });
            countryList.Add(new SelectListItem { Text = "USA", Value = "US" });
            Utilities.SortSelectList(countryList,countries);
            HttpContext.Session.SetString("countryList", JsonSerializer.Serialize(countryList));
        }
        else
        {
            countryList = JsonSerializer.Deserialize<List<SelectListItem>>(json);
        }

        ViewBag.countries = countryList;
        ViewBag.countryCode = countries;
        return View();
    }


    [HttpPost]
    public ActionResult Index(IFormCollection formData)
    {
        var json = HttpContext.Session.GetString("countryList");
        countryList = JsonSerializer.Deserialize<List<SelectListItem>>(json);


        if (countryList != null)
        {
            countryList.Add(new SelectListItem { Text = formData["countryName"], Value = formData["code"] });
            
            Utilities.SortSelectList(countryList,formData["code"].ToString());
            HttpContext.Session.SetString("countryList", JsonSerializer.Serialize(countryList));

            ViewBag.countries = countryList;
            ViewBag.countryCode = formData["code"].ToString();

        }
        else throw new NullReferenceException("countrylist er null");

        return View();
    }
}

    