using AutismAppJam.Data;
using AutismAppJam.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Microsoft.AspNet.Identity;
using System.Security.Claims;

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
            if(question == null)
            {
                question = new List<string>();
            }

            int eSum, iSum, sSum, nSum, tSum, fSum, jSum, pSum;
            eSum = iSum = sSum = nSum = tSum = fSum = jSum = pSum = 0;

            String resultType = "";

            // Accumulates points from MBTI 
            foreach (string s in question)
            {
                if (s.Equals("E1"))
                    eSum++;
                if (s.Equals("I1"))
                    iSum++;
                if (s.Equals("S1"))
                    sSum++;
                if (s.Equals("S2"))
                    sSum++;
                if (s.Equals("N2"))
                    nSum++;
                if (s.Equals("T1"))
                    tSum++;
                if (s.Equals("F1"))
                    fSum++;
                if (s.Equals("T2"))
                    tSum++;
                if (s.Equals("F2"))
                    fSum++;
                if (s.Equals("J1"))
                    jSum++;
                if (s.Equals("P1"))
                    pSum++;
                if (s.Equals("J2"))
                    jSum++;
                if (s.Equals("P2"))
                    pSum++;
            }

            // Calculates Type 
            if (eSum >= iSum)
                resultType += "E";
            else
                resultType += "I";

            if (sSum >= nSum)
                resultType += "S";
            else
                resultType += "N";

            if (tSum >= fSum)
                resultType += "T";
            else
                resultType += "F";

            if (jSum >= pSum)
                resultType += "J";
            else
                resultType += "P";

            PersonalityRepository pr = new PersonalityRepository();
            Personality personality = pr.GetPersonality(resultType);

            var userRepository = new UserRepository();
            userRepository.UpdateUserPersonalityType(User.Identity.GetUserId(), personality);

            return RedirectToAction("Index", "Dashboard");
        }
    }
}
