using System.Runtime.ExceptionServices;
using Microsoft.AspNetCore.Mvc;

namespace opgave_1.Controllers;

public class SimpleCalculatorController : Controller
{
    // GET
    public IActionResult SimpleCalculator()
    {
        
        return View();
    }

    [HttpPost]
    public IActionResult SimpleCalculator(IFormCollection formCollection)
    {
        
        var first = Convert.ToDouble(formCollection["first"]);
        
        var second = Convert.ToDouble(formCollection["second"]);
        ViewBag.first = first.ToString();
        ViewBag.second = second.ToString();
        
        var operat = formCollection["operator"];

        switch (operat)
        {
            case "+":
                var plus = first + second;
                ViewBag.Number = plus;
                break;
            case "-":
                var minus =  first - second;
                ViewBag.Number = minus;
                break;
            case "*":
                var multiply =  first * second;
                ViewBag.Number = multiply;
                break;
            case "/":
                if (second == 0)
                {
                    ViewBag.Number = 0;
                }
                else
                {
                    var division =   first / second;
                    ViewBag.Number = division;
                }
                break;
        }
        return View();
    }
}