using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week6CodeChallenge1.Controllers
{
    public class WorkController : Controller
    {
        //
        // GET: /Work/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult topleft()
        {
            return PartialView();
        }
        public ActionResult topright()
        {
            return PartialView(); 
        }
        public ActionResult botleft()
        {
            return PartialView();
        }
        public ActionResult botright()
        {
            return PartialView();
        }

    }
}
