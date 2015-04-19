using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Microsoft.AspNet.Identity;
using AutismAppJam.Data;
using System.Security.Claims;
using AutismAppJam.Repositories;

namespace AutismAppJam.Controllers
{
    public class DashboardController : Controller
    {
        //
        // GET: /Dashboard/
        [Authorize]
        public ActionResult Index()
        {
            String userId = User.Identity.GetUserId();
            
            var userRepository = new UserRepository();

            var user = userRepository.GetUserById(userId);

            return View(user);
        }

    }
}
