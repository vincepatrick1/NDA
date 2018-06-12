using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NDASite.Models;

namespace NDASite.Controllers
{
    public class TeamController : Controller
    {
        private TeamViewModel team=new TeamViewModel();

        // GET: Team
        public ActionResult Index()
        {
            return View(team);
        }
    }
}