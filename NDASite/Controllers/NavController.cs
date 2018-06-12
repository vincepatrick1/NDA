using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NDASite.Controllers
{
    public class NavController : Controller
    {
        public PartialViewResult Header()
        {
            return PartialView();
        }
        public PartialViewResult Footer()
        {
            return PartialView();
        }
    }
}