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
            int eSum, iSum, sSum, nSum, tSum, fSum, jSum, pSum;
            eSum = iSum = sSum = nSum = tSum = fSum = jSum = pSum = 0;

            foreach (string s in question)
            {
                if (s == "E1")
                    eSum++;
                if (s == "I1")
                    iSum++;
                if (s == "S1")
                    sSum++;
                if (s == "S2") 
                    sSum++;
                if (s == "N2") 
                    nSum++;
                if (s == "T1")
                    tSum++;
                if (s == "F1")
                    fSum++;
                if (s == "T2") 
                    tSum++;
                if (s == "F2")
                    fSum++;
                if (s == "J1") 
                    jSum++;
                if (s == "P1") 
                    pSum++;
                if (s == "J2") 
                    jSum++;
                if (s == "P2") 
                    pSum++;


            }
            return View();
        }
    }
}
