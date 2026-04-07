
using Domain;
using Microsoft.AspNetCore.Mvc;
using Business;
namespace Presentation.Controllers;

public class StuderendeController : Controller
{
    private StuderendeService service = new StuderendeService();

    public IActionResult Index()
    {
        var list = service.GetAll();
        return View(list);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Studerende s)
    {
        try
        {
            service.Create(s);
            return RedirectToAction("Index");
        }
        catch (Exception e)
        {
            ViewBag.Error = e.Message;
            return View();
        }
    }

    public IActionResult Delete(int id)
    {
        service.Delete(id);
        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        var s = service.GetById(id);
        return View(s);
    }

    [HttpPost]
    public IActionResult Edit(Studerende s)
    {
        service.Update(s);
        return RedirectToAction("Index");
    }
}