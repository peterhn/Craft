using AutismAppJam.Models;
using AutismAppJam.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Microsoft.AspNet.Identity;

namespace AutismAppJam.Controllers
{
    public class VideosController : Controller
    {
        public ActionResult Index()
        {
            DashboardModel dashboardModel = new DashboardModel();
            dashboardModel.User = new UserRepository().GetUserById(User.Identity.GetUserId());
            dashboardModel.Personality = new PersonalityRepository().GetPersonality(dashboardModel.User.PersonalityType);
            return View(dashboardModel);
        }
    }
}