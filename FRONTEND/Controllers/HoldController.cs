using Business;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace FRONTEND.Controllers;

public class HoldController : Controller
{
    private HoldService holdService = new HoldService();
    private StuderendeService studerendeService = new StuderendeService();

    public IActionResult Index()
    {
        return View(holdService.GetAll());
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Hold h)
    {
        holdService.CreateHold(h);
        return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
        var hold = holdService.GetByID(id);
        var alleStuderende = studerendeService.GetAll();

        ViewBag.Studerende = alleStuderende;

        return View(hold);
    }

    public IActionResult AddStuderende(int holdId, int studerendeId)
    {
        holdService.AddStuderende(holdId, studerendeId);
        return RedirectToAction("Details", new { id = holdId });
    }

    public IActionResult RemoveStuderende(int holdId, int studerendeId)
    {
        holdService.RemoveStuderende(studerendeId);
        return RedirectToAction("Details", new { id = holdId });
    }
}