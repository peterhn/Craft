using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace AutismAppJam.Controllers
{

    [Authorize]
    public class StroopTestController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(List<string> questions, int testDuration)
        {


            return View();
        }
    }
}
