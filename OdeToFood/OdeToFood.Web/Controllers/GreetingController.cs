using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Web.Models;

namespace OdeToFood.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index(string name)
        {
            GreetingViewModel model = new GreetingViewModel
            {
                Name = name ?? "No data"
            };
            return View(model);
        }
    }
}