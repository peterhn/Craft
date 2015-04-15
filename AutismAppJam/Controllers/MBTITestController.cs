using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutismAppJam.Controllers
{
    public class MBTITestController : Controller
    {
        //
        // GET: /MBTITest/
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(List<string> question)
        {

            return View();
        }
    }
}
