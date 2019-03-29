using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hello_world.Models
{
    public class SimpleBindController : Controller
    {
        // GET: SimpleBind/SimpleBindMetoda
        public ViewResult SimpleBindMetoda()
        {
            return View("SimpleBind");
        }
        //POST SimpleBind

        [HttpPost]
        public ViewResult SimpleBindMetoda(string ime)
        {
            string pozdrav = "Pozdav, " + ime + "!";
            return View("SimpleBind", (object)pozdrav);
        }
    }
}