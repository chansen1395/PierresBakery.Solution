using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using Bakery.Models;
using System.Threading.Tasks;
using System.Linq;


namespace Bakery.Controllers
{
    public class HomeController : Controller
    {
      private readonly BakeryContext _db;
      public HomeController(BakeryContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      public ActionResult ViewAll()
      {
        dynamic modelAll = new ExpandoObject();
        modelAll.Flavors = _db.Flavors.ToList();
        modelAll.Treats = _db.Treats.ToList();
        return View(modelAll);
      }

    }
}