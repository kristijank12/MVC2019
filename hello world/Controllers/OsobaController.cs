using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hello_world.Models;

namespace hello_world.Controllers
{
    public class OsobaController : Controller
    {
        // GET: Osoba
        public ActionResult PopuniOsobu()
        {
            return View();
        }
        [HttpPost]
        public ViewResult  PrikaziOsobu(Osoba osoba)
        {
            return View(osoba);


        }
    }
}