using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIgrid.Controllers
{
    public class ScoreCardController : Controller
    {
        //
        // GET: /ScoreCard/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Card(string id)
        {
            ViewData["id"] = id;
            return View();
        }
    }
}
