using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ado_net_spajanje_na_bazu.Controllers
{
    public class SqlConnectionObjectController : Controller
    {
        // GET: SqlConnectionObject
        public ActionResult Index()
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlgebra;Integrated Security=True";
            return View();
        }
    }
}