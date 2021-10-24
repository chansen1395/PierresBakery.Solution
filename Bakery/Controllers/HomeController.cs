using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using Bakery.Models;
using System.Threading.Tasks;
using System.Linq;
using System;
using System.Collections.Generic;


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

      public ActionResult Search(string searchString)
      {
        dynamic searchAll = new ExpandoObject();
        searchAll.Flavors = _db.Flavors.Where(flavor => flavor.FlavorName.Contains(searchString)).ToList();
        searchAll.Treats = _db.Treats.Where(treat => treat.TreatName.Contains(searchString)).ToList();
       
        return View(searchAll);

        // List<Flavor> model = 
        //   _db.Flavors.Where(flavor => flavor.FlavorName.Contains(searchString)).ToList();

        // return View(model);
      }

    }
}