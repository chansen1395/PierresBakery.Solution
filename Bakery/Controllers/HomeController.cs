using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace Bakery.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      public ActionResult ViewAll()
      {
        dynamic sampleObject = new ExpandoObject();
        sampleObject.test1 = "hello";
        sampleObject.test2 = "there";
        return View(sampleObject);
      }

    }
}