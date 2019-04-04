using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hello_world.Models;

namespace hello_world.Controllers
{
    public class TemplHtmlHelperiController : Controller
    {
        // GET: TemplHtmlHelperi
        public ViewResult HtmlEditorView()
        {
            return View(new OsobaTempt());
        }

        [HttpPost]
        public ViewResult HtmlEditorView(OsobaTempt osoba)
        {
            return View("HtmlLabelDisplay", osoba);
        }
    }
}