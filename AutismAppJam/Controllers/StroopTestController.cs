using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace AutismAppJam.Controllers
{
    public class StroopTestController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index(List<string> questions)
        {


            return View();
        }
    }
}
