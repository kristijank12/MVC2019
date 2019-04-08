using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validacije.Models;

namespace Validacije.Controllers
{
    public class ValidacijeController : Controller
    {
        // GET: Validacije
        public ViewResult Izdavanjeracuna()
        {
            return View(new Racun() {Datum = DateTime.Now, BrojRacuna = "/");
        }
    }
}