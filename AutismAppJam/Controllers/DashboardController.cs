using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Microsoft.AspNet.Identity;
using AutismAppJam.Data;
using System.Security.Claims;
using AutismAppJam.Repositories;
using AutismAppJam.Models;

namespace AutismAppJam.Controllers
{
    public class DashboardController : Controller
    {
        //
        // GET: /Dashboard/
        [Authorize]
        public ActionResult Index()
        {
            string userId = User.Identity.GetUserId();
            
            var userRepository = new UserRepository();
            var personalityRepository = new PersonalityRepository();
            var occupationalTrendsRepository = new OccupationalTrendsRepository();

            var user = userRepository.GetUserById(userId);
            var personality = personalityRepository.GetPersonality(user.PersonalityType);
            var occupationalTrends = occupationalTrendsRepository.GetOccupationalTrendsByPersonalityType(user.PersonalityType);
            
            DashboardModel dashboardModel = new DashboardModel();
            dashboardModel.User = user;
            dashboardModel.Personality = personality;
            dashboardModel.OccupationalTrends = occupationalTrends;

            return View(dashboardModel);
        }

    }
}
