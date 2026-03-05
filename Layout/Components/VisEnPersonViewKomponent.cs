using Layout.Models;
using Microsoft.AspNetCore.Mvc;

namespace Layout.Components;

public class VisEnPersonViewComponent: ViewComponent
{
    public IViewComponentResult Invoke(Person p)
    {
        (p.Name, p.Surname) = (p.Surname, p.Name);
        return View(p);
    }
}