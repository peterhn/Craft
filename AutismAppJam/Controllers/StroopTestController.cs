using AutismAppJam.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

using Microsoft.AspNet.Identity;
using System.Security.Claims;

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
            if (questions == null)
            {
                questions = new List<string>();
            }

            double attentionSpanInitial = 0;

            int attentionSpanFinal = 0;

            double timeValue = 0;
                
            double rightSum = 0;

            foreach (string s in questions)
            {

                if(s.Equals("right"))
                {
                    rightSum++;
                }

            }

            timeValue = testDuration * 0.01;

            attentionSpanInitial = rightSum / timeValue;

            if (attentionSpanInitial >= 30)
            {
                attentionSpanFinal = 3;
            }
            else if (attentionSpanInitial < 30 && attentionSpanInitial >= 15)
            {
                attentionSpanFinal = 2;
            }
            else
            {
                attentionSpanFinal = 1;
            }


            var userRepository = new UserRepository();

            userRepository.UpdateUserAttentionSpan(User.Identity.GetUserId(), attentionSpanFinal);

            return RedirectToAction("Index", "Dashboard");

        }
    }
}
