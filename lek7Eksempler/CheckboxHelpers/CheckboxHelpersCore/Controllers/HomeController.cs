using Microsoft.AspNetCore.Mvc;

namespace CheckboxHelpers.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public String Postback(IFormCollection formCollection)
        {
            String check1 = formCollection["Check1"];
            String check2 = formCollection["Check2"];
            String check3 = formCollection["Check3"];
            return "Check1:" + check1 + ", Check2:" + check2 + ", Check3:" + check3;
        }
        [HttpPost]
        public String Postback2(FormCollection formCollection)
        {
            String retur = "";
            String choices = formCollection["Choices"];
            String[] separated = choices.Split(',');
            foreach (String s in separated)
            {
                if (s != "false")
                {
                    retur += s + " og ";
                }
            }

            //if (separated.Contains("Choice1"))
            //{
            //    //retur +=
            //}
            return retur;
        }
    }
}